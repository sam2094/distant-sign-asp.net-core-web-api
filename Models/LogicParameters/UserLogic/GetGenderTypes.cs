using Models.Dtos.UserDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.UserLogic
{
    public class GetGenderTypesOutput : LogicOutput
    {
        public List<GenderTypeDto> GenderTypes { get; set; }

    }
}
