using Models.Dtos.UserDtos;

namespace Models.LogicParameters.UserLogic
{
    public class GetCurrentUserInput : LogicInput
    {
    }

    public class GetCurrentUserOutput : LogicOutput
    {
        public UserDto User { get; set; }
    }
}
