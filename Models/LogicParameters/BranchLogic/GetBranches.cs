using Models.Dtos.BranchDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.BranchLogic
{
    public class GetBranchesOutput : LogicOutput
    {
        public List<GetBranchesDto> Branches { get; set; }
    }
}
