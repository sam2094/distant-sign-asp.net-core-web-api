using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Dtos.UserDtos;
using Models.Entities;
using Models.LogicParameters.UserLogic;

namespace BusinessLogic.Logic.UserLogic
{
    public class GetClaims : Logic<int,GetClaimsOutput>
    {
        public GetClaims(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            User user = await _uow.UserRepository.GetAsync(x => x.Id == Parameters);

            if (user == null)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.ACCESS_DENIED,
                    ErrorMessage = Resource.ACCESS_DENIED,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            List<Claim> claims = _uow.RoleClaimRepository.GetAll(x => x.RoleId == user.RoleId, i => i.Claim).Select(x => new Claim
            {
                Id = x.Claim.Id,
                Name = x.Claim.Name,
                Description = x.Claim.Description,
                AddedDate = x.Claim.AddedDate
            }).ToList();

            Result.Output.Claims = new List<ClaimDto>(claims
                .Select(x => (ClaimDto)x));
        }
    }
}
