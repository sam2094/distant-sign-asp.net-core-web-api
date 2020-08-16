using Models.LogicParameters.UserLogic;
using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Common.Helpers;

namespace BusinessLogic.Logic.UserLogic
{
	public class UserRegister : Logic<UserRegisterInput, UserRegisterOutput>
	{
		public UserRegister(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = true) :
			   base(UoW, FirstExecutedLogicName, beginTransaction)
		{ }

		public override async Task DoExecuteAsync()
		{
			Role role = await _uow.GetRepository<Role>().GetAsync(x => x.Id == Parameters.RoleId);

			if (role == null)
			{
				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.ROLE_DOES_NOT_EXIST,
					ErrorMessage = Resource.ROLE_DOES_NOT_EXIST,
					StatusCode = ErrorHttpStatus.NOT_FOUND
				});
				return;
			}

			if (!await _uow.GetRepository<UserStatus>().IsExistAsync(x => x.Id == Parameters.StatusId)) {

				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.USER_STATUS_DOES_NOT_EXIST,
					ErrorMessage = Resource.USER_STATUS_DOES_NOT_EXIST,
					StatusCode = ErrorHttpStatus.NOT_FOUND
				});
				return;
			}

			if (!await _uow.GetRepository<GenderType>().IsExistAsync(x => x.Id == Parameters.GenderTypeId))
			{

				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.GENDER_TYPE_DOES_NOT_EXIST,
					ErrorMessage = Resource.GENDER_TYPE_DOES_NOT_EXIST,
					StatusCode = ErrorHttpStatus.NOT_FOUND
				});
				return;
			}

			if (!await _uow.GetRepository<CitizenType>().IsExistAsync(x => x.Id == Parameters.CitizenTypeId))
			{

				Result.ErrorList.Add(new Error
				{
					ErrorCode = ErrorCodes.CITIZEN_TYPE_DOES_NOT_EXIST,
					ErrorMessage = Resource.CITIZEN_TYPE_DOES_NOT_EXIST,
					StatusCode = ErrorHttpStatus.NOT_FOUND
				});
				return;
			}

			byte[] salt = Hashing.RandomSalt();
			string password = Parameters.Password;

			User user = new User
			{
				FullName = Parameters.Fullname, 
				Username = Parameters.Username,
				Pin = Parameters.Pin,
				RoleId = Parameters.RoleId,
				StatusId = Parameters.StatusId,
				CitizenTypeId = Parameters.CitizenTypeId,
				GenderTypeId = Parameters.GenderTypeId,
				Salt = salt,
				Password = Hashing.Hash(salt, password)
			};

			await _uow.UserRepository.AddAsync(user);
			await _uow.SaveChangesAsync();
		}
	}
}
