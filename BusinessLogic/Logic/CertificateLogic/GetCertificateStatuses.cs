using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.CertificateDtos;
using Models.Entities;
using Models.LogicParameters.CertificateLogic;

namespace BusinessLogic.Logic.CertificateLogic
{
    public class GetCertificateStatuses : LogicSingleParam<GetCertificateStatusesOutput>
    {
        public GetCertificateStatuses(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
                base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

		public override void DoExecute()
		{
            Result.Output.CertificateStatuses = new List<CertificateStatusDto>(_uow.GetRepository<CertificateStatus>().GetAll()
                .Select(x => (CertificateStatusDto)x));
        }
	}
}
