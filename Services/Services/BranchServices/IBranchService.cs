using Models.LogicParameters;
using Models.LogicParameters.BranchLogic;
using System.Threading.Tasks;

namespace Services.Services.BranchServices
{
    public interface IBranchService
    {
        Task<LogicResult<AddBranchOutput>> AddBranchAsync(AddBranchInput input);
        Task<LogicResult<UpdateBranchOutput>> UpdateBranchAsync(UpdateBranchInput input);
        Task<LogicResult<GetBranchesOutput>> GetBranchesAsync();
        Task<LogicResult<GetBranchOutput>> GetBranchAsync(int input);
        Task<LogicResult<AddBranchesOutput>> AddBranchesAsync(AddBranchesInput input);
    }
}
