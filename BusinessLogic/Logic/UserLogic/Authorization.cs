using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.UserLogic;

namespace BusinessLogic.Logic.UserLogic
{
	public class Authorization : Logic<AuthorizationInput, AuthorizationOutput>
	{
		public Authorization(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
			   base(UoW, FirstExecutedLogicName, beginTransaction)
		{ }

		public override async Task DoExecuteAsync()
		{
			User user = await _uow.UserRepository.GetAsync(x => x.Id == Parameters.CurrentUserId,
				  i => i.Role.RoleClaims);

			if (user == null)
			{
				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.CLAIM_DOES_NOT_EXIST,
					ErrorMessage = Resource.CLAIM_DOES_NOT_EXIST,
					StatusCode = ErrorHttpStatus.VALIDATION
				});
				return;
			}

			List<Claim> userClaims = _uow.RoleClaimRepository.GetAll(x => x.RoleId == user.RoleId, i => i.Claim, i => i.Role)
							.Select(x => new Claim
							{
								Id = x.Claim.Id,
								Name = x.Claim.Name,
								Description = x.Claim.Description,
								AddedDate = x.Claim.AddedDate
							}).ToList();


			if (!userClaims.Any(x => x.Id == Parameters.ClaimId))
			{
				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.CLAIM_DOES_NOT_EXIST,
					ErrorMessage = Resource.CLAIM_DOES_NOT_EXIST,
					StatusCode = ErrorHttpStatus.VALIDATION
				});
				return;
			}
		}
	}
}
