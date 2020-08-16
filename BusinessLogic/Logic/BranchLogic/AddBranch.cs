using System;
using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.BranchLogic;

namespace BusinessLogic.Logic.BranchLogic
{
    public class AddBranch : Logic<AddBranchInput, AddBranchOutput>
    {
        public AddBranch(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = true) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {

            if (!await _uow.OrganizationRepository.IsExistAsync(x => x.Id == Parameters.OrganizationId))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.ORGANIZATION_DOES_NOT_EXIST,
                    ErrorMessage = Resource.ORGANIZATION_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.NOT_FOUND
                });
                return;
            }

            if (await _uow.BranchRepository.IsExistAsync(x => x.Name.ToUpper().Trim() == Parameters.Name.ToUpper().Trim()
               && x.OrganizationId == Parameters.OrganizationId))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.BRANCH_NAME_IS_EXIST,
                    ErrorMessage = Resource.BRANCH_NAME_IS_EXIST,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            Branch branch = new Branch
            {
                Name = Parameters.Name.Trim(),
                Address = Parameters.Address.Trim(),
                OrganizationId = Parameters.OrganizationId,
                AddedDate = DateTime.Now
            };

            await _uow.BranchRepository.AddAsync(branch);
            await _uow.SaveChangesAsync();

            Result.Output.Branch = branch;
        }
    }
}
