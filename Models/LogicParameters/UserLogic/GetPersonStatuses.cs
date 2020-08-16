using Models.Dtos.UserDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.UserLogic
{
    public class GetPersonStatusesOutput : LogicOutput
    {
        public List<PersonStatusDto> PersonStatuses { get; set; }
    }
}
