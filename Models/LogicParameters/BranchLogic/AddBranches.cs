using Models.Dtos.BranchDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.BranchLogic
{
    public class AddBranchesInput
    {
        public List<AddBranchesInputDto> Branches { get; set; }
        public int OrganizationId { get; set; }
    }

    public class AddBranchesOutput : LogicOutput
    {
        public List<AddBranchesOutputDto> AddBranches { get; set; }
    }
}
