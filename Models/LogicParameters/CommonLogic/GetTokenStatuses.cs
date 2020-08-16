using Models.Dtos.CommonDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.CommonLogic
{
    public class GetTokenStatusesOutput : LogicOutput
    {
        public List<TokenStatusDto> TokenStatuses { get; set; }
    }
}
