using System.Threading.Tasks;
using Models.LogicParameters;
using Models.LogicParameters.UserLogic;

namespace Services.Services.UserServices
{
	public interface IUserService
	{
		Task<LogicResult<AuthenticateOutput>> Authenticate(AuthenticateInput input);
		Task<LogicResult<AuthorizationOutput>> Authorization(AuthorizationInput input);
		Task<LogicResult<UserRegisterOutput>> UserRegister(UserRegisterInput input);
		Task<LogicResult<GetUserByIdOutput>> GetUserById(GetUserByIdInput input);
		Task<LogicResult<GetCurrentUserOutput>> GetCurrentUser(GetCurrentUserInput input);
		LogicResult<GetGenderTypesOutput> GetGenderTypes();
		LogicResult<GetUserStatusesOutput> GetUserStatuses();
		LogicResult<GetCitizenTypesOutput> GetCitizenTypes();
		LogicResult<GetPersonStatusesOutput> GetPersonStatuses();
		Task<LogicResult<GetClaimsOutput>> GetClaims(int input);
		Task<LogicResult<GetRolesOutput>> GetRoles(int input);
	}
}
