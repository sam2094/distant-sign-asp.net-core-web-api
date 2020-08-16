using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.CertificateDtos;
using Models.Entities;
using Models.LogicParameters.CertificateLogic;

namespace BusinessLogic.Logic.CertificateLogic
{
   public class GetCertificateTypes : LogicSingleParam<GetCertificateTypesOutput>
    {
        public GetCertificateTypes(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.CertificateTypes = new List<CertificateTypeDto>(_uow.GetRepository<CertificateType>().GetAll()
                .Select(x => (CertificateTypeDto)x));
        }
    }
}
