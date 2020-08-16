using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.CertificateDtos;
using Models.Entities;
using Models.LogicParameters.CertificateLogic;

namespace BusinessLogic.Logic.CertificateLogic
{
    public class GetOperationPriceTypes : LogicSingleParam<GetOperationPriceTypesOutput>
    {
        public GetOperationPriceTypes(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.OperationPriceTypes = new List<OperationPriceTypeDto>(_uow.GetRepository<OperationPriceType>().GetAll()
                .Select(x => (OperationPriceTypeDto)x));
        }
    }
}
