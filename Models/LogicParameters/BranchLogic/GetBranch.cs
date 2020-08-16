using Models.Dtos.BranchDtos;

namespace Models.LogicParameters.BranchLogic
{
    public class GetBranchOutput : LogicOutput
    {
        public GetBranchDto Branch { get; set; }
    }
}
