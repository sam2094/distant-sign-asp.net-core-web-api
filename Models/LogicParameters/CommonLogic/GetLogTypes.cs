using Models.Dtos.CommonDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.CommonLogic
{
    public class GetLogTypesOutput : LogicOutput
    {
        public List<LogTypeDto> LogTypes { get; set; }
    }
}
