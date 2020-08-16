using Models.Dtos.CertificateDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.CertificateLogic
{
	public class GetCertificateStatusesOutput : LogicOutput
	{
        public List<CertificateStatusDto> CertificateStatuses { get; set; }
    }
}
