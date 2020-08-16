using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Logic.UserLogic;
using Common.Enums.ErrorEnums;
using Common.Helpers;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.LogicParameters.UserLogic;
using Models.LogicParameters;

namespace Services.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly AppSettings _appSettings;
        public UserService(IUnitOfWork uow, IOptions<AppSettings> appSettings)
        {
            _uow = uow;
            _appSettings = appSettings.Value;
        }

        public async Task<LogicResult<AuthenticateOutput>> Authenticate(AuthenticateInput input)
        {
            LogicResult<AuthenticateOutput> result = await new Authenticate(_uow, nameof(Authenticate)).ExecuteAsync(parameters: input);

            if (result.IsSuccess)
            {
                try
                {
                    // authentication successful so generate jwt token
                    JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                    SecurityToken token = tokenHandler.CreateToken(new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim(ClaimTypes.Name, result.Output.UserId.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(5),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appSettings.Secret)),
                        SecurityAlgorithms.HmacSha256Signature)
                    });
                    result.Output.Token = string.Concat(AppSettings.JwtScheme, tokenHandler.WriteToken(token));
                }
                catch (Exception ex)
                {
                    result.ErrorList.Add(new Common.Error
                    {
                        ErrorCode = ErrorCodes.INTERNAL_ERROR,
                        ErrorMessage = Resource.UNHANDLED_EXCEPTION,
                        StatusCode = ErrorHttpStatus.INTERNAL
                    });
                }
            }
            return result;
        }

        public async Task<LogicResult<AuthorizationOutput>> Authorization(AuthorizationInput input)
         => await new Authorization(_uow, nameof(Authorization)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<UserRegisterOutput>> UserRegister(UserRegisterInput input)
        => await new UserRegister(_uow, nameof(UserRegister)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<GetUserByIdOutput>> GetUserById(GetUserByIdInput input)
            => await new GetUserById(_uow, nameof(GetUserById)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<GetCurrentUserOutput>> GetCurrentUser(GetCurrentUserInput input)
            => await new GetCurrentUser(_uow, nameof(GetCurrentUser)).ExecuteAsync(parameters: input);

        public LogicResult<GetGenderTypesOutput> GetGenderTypes()
            => new GetGenderTypes(_uow, nameof(GetGenderTypes)).Execute();

        public LogicResult<GetUserStatusesOutput> GetUserStatuses()
            => new GetUserStatuses(_uow, nameof(GetUserStatuses)).Execute();

        public LogicResult<GetCitizenTypesOutput> GetCitizenTypes()
            => new GetCitizenTypes(_uow, nameof(GetCitizenTypes)).Execute();

        public LogicResult<GetPersonStatusesOutput> GetPersonStatuses()
            => new GetPersonStatuses(_uow, nameof(GetPersonStatuses)).Execute();

        public async Task<LogicResult<GetClaimsOutput>> GetClaims(int input)
           => await  new GetClaims(_uow, nameof(GetClaims)).ExecuteAsync(input);

        public async Task<LogicResult<GetRolesOutput>> GetRoles(int input)
          => await new GetRoles(_uow, nameof(GetRoles)).ExecuteAsync(input);
    }
}
