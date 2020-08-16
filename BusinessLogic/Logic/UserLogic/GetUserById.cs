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
	public class GetUserById : Logic<GetUserByIdInput, GetUserByIdOutput>
	{
		public GetUserById(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
			   base(UoW, FirstExecutedLogicName, beginTransaction)
		{ }

		public override async Task DoExecuteAsync()
		{
			User user = await _uow.UserRepository.GetAsync(x => x.Id == Parameters.UserId, i => i.Role, i => i.Status);

			if (user == null)
			{
				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.USER_DOES_NOT_EXIST,
					ErrorMessage = Resource.USER_DOES_NOT_EXIST,
					StatusCode = ErrorHttpStatus.NOT_FOUND
				});
				return;
			}

			Result.Output.User = (UserDto)user;
		}
	}
}
