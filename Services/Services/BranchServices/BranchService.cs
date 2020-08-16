using BusinessLogic.Logic.BranchLogic;
using DataAccess.UnitofWork;
using Models.LogicParameters;
using Models.LogicParameters.BranchLogic;
using System.Threading.Tasks;

namespace Services.Services.BranchServices
{
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWork _uow;

        public BranchService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<LogicResult<AddBranchOutput>> AddBranchAsync(AddBranchInput input)
         => await new AddBranch(_uow, nameof(AddBranchAsync)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<UpdateBranchOutput>> UpdateBranchAsync(UpdateBranchInput input)
         => await new UpdateBranch(_uow, nameof(UpdateBranchAsync)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<GetBranchesOutput>> GetBranchesAsync()
         => await new GetBranches(_uow, nameof(GetBranchesAsync)).ExecuteAsync();

        public async Task<LogicResult<AddBranchesOutput>> AddBranchesAsync(AddBranchesInput input)
         => await new AddBranches(_uow, nameof(AddBranchesAsync)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<GetBranchOutput>> GetBranchAsync(int input)
         => await new GetBranch(_uow, nameof(GetBranchAsync)).ExecuteAsync(input);
    }
}
