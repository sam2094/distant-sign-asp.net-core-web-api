using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.CommonDtos;
using Models.Entities;
using Models.LogicParameters.CommonLogic;

namespace BusinessLogic.Logic.CommonLogic
{
   public class GetLogTypes : LogicSingleParam<GetLogTypesOutput>
    {
        public GetLogTypes(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.LogTypes = new List<LogTypeDto>(_uow.GetRepository<LogType>().GetAll()
                .Select(x => (LogTypeDto)x));
        }
    }
}
