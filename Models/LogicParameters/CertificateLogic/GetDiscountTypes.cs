using Models.Dtos.CertificateDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.CertificateLogic
{
    public class GetDiscountTypesOuput  : LogicOutput
    {
        public List<DiscountTypeDto> DiscountTypes { get; set; }
    }
}
