using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.UserDtos;
using Models.Entities;
using Models.LogicParameters.UserLogic;

namespace BusinessLogic.Logic.UserLogic
{
   public class GetUserStatuses : LogicSingleParam<GetUserStatusesOutput>
    {
        public GetUserStatuses(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.UserStatuses = new List<UserStatusDto>(_uow.GetRepository<UserStatus>().GetAll()
                .Select(x => (UserStatusDto)x));
        }
    }
}
