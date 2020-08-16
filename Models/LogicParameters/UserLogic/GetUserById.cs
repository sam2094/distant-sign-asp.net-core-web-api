using Models.Dtos.UserDtos;

namespace Models.LogicParameters.UserLogic
{
    public class GetUserByIdInput : LogicInput
    {
        public int UserId { get; set; }
    }

    public class GetUserByIdOutput : LogicOutput
    {
        public UserDto User { get; set; }
    }
}
