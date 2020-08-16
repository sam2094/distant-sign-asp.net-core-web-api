using Models.Dtos.UserDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.UserLogic
{
    public class GetUserStatusesOutput : LogicOutput
    {
        public List<UserStatusDto> UserStatuses { get; set; }
    }
}
