using Models.Dtos.CommonDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.CommonLogic
{
    public class GetOtpCodeStatusesOutput : LogicOutput
    {
        public List<OtpCodeStatusDto> OtpCodeStatuses { get; set; }

    }
}
