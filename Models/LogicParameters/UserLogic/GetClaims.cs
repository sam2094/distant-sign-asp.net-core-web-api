using Models.Dtos.UserDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.UserLogic
{
    public class GetClaimsOutput : LogicOutput
    {
        public List<ClaimDto> Claims { get; set; }
    }
}
