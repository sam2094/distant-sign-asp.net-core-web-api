using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.BranchLogic;

namespace BusinessLogic.Logic.BranchLogic
{
    public class GetBranch : Logic<int, GetBranchOutput>
    {
        public GetBranch(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            Branch branch = await _uow.BranchRepository.GetAsync(x => x.Id == Parameters, i => i.Organization);

            if (branch == null)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.BRANCH_DOES_NOT_EXIST,
                    ErrorMessage = Resource.BRANCH_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.NOT_FOUND
                });
                return;
            }

            Result.Output.Branch = branch;
        }
    }
}
