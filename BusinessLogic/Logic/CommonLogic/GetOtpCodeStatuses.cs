using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.CommonDtos;
using Models.Entities;
using Models.LogicParameters.CommonLogic;

namespace BusinessLogic.Logic.CommonLogic
{
    public class GetOtpCodeStatuses : LogicSingleParam<GetOtpCodeStatusesOutput>
    {
        public GetOtpCodeStatuses(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.OtpCodeStatuses = new List<OtpCodeStatusDto>(_uow.GetRepository<OtpCodeStatus>().GetAll()
                .Select(x => (OtpCodeStatusDto)x));
        }
    }

}
