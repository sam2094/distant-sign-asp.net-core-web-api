using Models.Dtos.CertificateDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.CertificateLogic
{
    public class GetCertificateTypesOutput : LogicOutput
    {
        public List<CertificateTypeDto> CertificateTypes { get; set; }
    }
}
