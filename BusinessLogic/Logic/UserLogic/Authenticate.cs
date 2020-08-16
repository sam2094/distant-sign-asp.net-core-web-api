using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Helpers;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.UserLogic;

namespace BusinessLogic.Logic.UserLogic
{
	public class Authenticate : Logic<AuthenticateInput, AuthenticateOutput>
	{
		public Authenticate(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
			   base(UoW, FirstExecutedLogicName, beginTransaction)
		{ }

		public override async Task DoExecuteAsync()
		{
			User user = await _uow.UserRepository.GetAsync(x => x.Username.Trim().ToUpper() == Parameters.Username.Trim().ToUpper());

			if (user == null || !user.Password.SequenceEqual(Hashing.Hash(user.Salt, Parameters.Password)))
			{
				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.USERNAME_AND_PASSWORD_DOESNT_MATCH,
					ErrorMessage = Resource.USERNAME_AND_PASSWORD_DOESNT_MATCH,
					StatusCode = ErrorHttpStatus.FORBIDDEN
				});
				return;
			}

			Result.Output.UserId = user.Id;
		}
	}
}
