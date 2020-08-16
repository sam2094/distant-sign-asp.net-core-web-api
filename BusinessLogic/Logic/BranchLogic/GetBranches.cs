using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.UnitofWork;
using Models.Dtos.BranchDtos;
using Models.Entities;
using Models.LogicParameters.BranchLogic;

namespace BusinessLogic.Logic.BranchLogic
{
    public class GetBranches : LogicSingleParam<GetBranchesOutput>
    {
        public GetBranches(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            List<Branch> branches = _uow.BranchRepository.GetAll(i => i.Organization).ToList();
            Result.Output.Branches = new List<GetBranchesDto>(branches.Select(x => (GetBranchesDto)x));
            await Task.CompletedTask;
        }
    }
}
