using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.UserDtos;
using Models.Entities;
using Models.LogicParameters.UserLogic;

namespace BusinessLogic.Logic.UserLogic
{
    public class GetPersonStatuses : LogicSingleParam<GetPersonStatusesOutput>
    {
        public GetPersonStatuses(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.PersonStatuses = new List<PersonStatusDto>(_uow.GetRepository<PersonStatus>().GetAll()
                .Select(x => (PersonStatusDto)x));
        }
    }
}
