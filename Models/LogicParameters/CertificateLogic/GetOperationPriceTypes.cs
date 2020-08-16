using Models.Dtos.CertificateDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.CertificateLogic
{
    public class GetOperationPriceTypesOutput : LogicOutput
    {
        public List<OperationPriceTypeDto> OperationPriceTypes { get; set; }

    }
}
