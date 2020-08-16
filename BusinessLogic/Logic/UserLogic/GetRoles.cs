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
    public class GetRoles : Logic<int, GetRolesOutput>
    {
        public GetRoles(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
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

            List<Role> roles = _uow.GetRepository<Role>().GetAll(x => x.Id >= user.RoleId).ToList();
           
            Result.Output.Roles = new List<RoleDto>(roles
                .Select(x => (RoleDto)x));
        }
    }
}
