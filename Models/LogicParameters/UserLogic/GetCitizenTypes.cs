using Models.Dtos.UserDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.UserLogic
{
    public class GetCitizenTypesOutput : LogicOutput
    {
        public List<CitizenTypeDto> CitizenTypes { get; set; }
    }
}
