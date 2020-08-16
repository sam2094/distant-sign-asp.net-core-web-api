using Models.Dtos.UserDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.UserLogic
{
    public class GetRolesOutput : LogicOutput
    {
        public List<RoleDto> Roles { get; set; }
    }
}
