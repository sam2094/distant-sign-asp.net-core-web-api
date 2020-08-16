using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.BranchLogic;

namespace BusinessLogic.Logic.BranchLogic
{
    public class UpdateBranch : Logic<UpdateBranchInput, UpdateBranchOutput>
    {
        public UpdateBranch(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = true) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {

            Branch branch = await _uow.BranchRepository.GetAsync(x => x.Id == Parameters.BranchId);

            if (branch == null)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.BRANCH_DOES_NOT_EXIST,
                    ErrorMessage = Resource.BRANCH_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            if (await _uow.BranchRepository.IsExistAsync(x => x.Name.ToUpper().Trim() == Parameters.Name.ToUpper().Trim()
            && x.Id != branch.Id
            && x.OrganizationId == branch.OrganizationId))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.BRANCH_NAME_IS_EXIST,
                    ErrorMessage = Resource.BRANCH_NAME_IS_EXIST,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            branch.Name = Parameters.Name.Trim();
            branch.Address = Parameters.Address.Trim();

            await _uow.SaveChangesAsync();

            Result.Output.Branch = branch;
        }
    }
}
