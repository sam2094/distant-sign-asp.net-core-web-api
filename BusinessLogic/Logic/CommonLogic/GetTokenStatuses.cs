using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.CommonDtos;
using Models.Entities;
using Models.LogicParameters.CommonLogic;

namespace BusinessLogic.Logic.CommonLogic
{
    public class GetTokenStatuses : LogicSingleParam<GetTokenStatusesOutput>
    {
        public GetTokenStatuses(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.TokenStatuses = new List<TokenStatusDto>(_uow.GetRepository<TokenStatus>().GetAll()
                .Select(x => (TokenStatusDto)x));
        }
    }
}
