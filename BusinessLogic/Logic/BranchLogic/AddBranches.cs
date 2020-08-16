using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Dtos.BranchDtos;
using Models.Entities;
using Models.LogicParameters.BranchLogic;

namespace BusinessLogic.Logic.BranchLogic
{
    public class AddBranches : Logic<AddBranchesInput, AddBranchesOutput>
    {
        public AddBranches(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = true) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            if (Parameters.Branches.Count == 0)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.INPUT_IS_NOT_VALID,
                    ErrorMessage = Resource.INVALID_INPUT,
                    StatusCode = ErrorHttpStatus.VALIDATION
                });
                return;
            }

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

            Result.Output.AddBranches = new List<AddBranchesOutputDto>();
            int position = 1;

            foreach (AddBranchesInputDto newBranch in Parameters.Branches)
            {
                AddBranchesOutputDto outputDto = new AddBranchesOutputDto
                {
                    BranchPosition = position,
                    BranchName = newBranch.Name ?? String.Empty,
                    Message = String.Empty,
                    IdAdded = true
                };

                if (newBranch.Name == null || newBranch.Name?.Trim().Length == 0)
                {
                    outputDto.Message = "Name cannot be empty";
                    outputDto.IdAdded = false;
                };

                if (newBranch.Address == null || newBranch.Address?.Trim().Length == 0)
                {
                    outputDto.Message = outputDto.Message.Length > 0 ? outputDto.Message + ", " + "Address cannot be empty" : "Address cannot be empty";
                    outputDto.IdAdded = false;
                };

                if (newBranch.Name?.Trim().Length > 0 && await _uow.BranchRepository.IsExistAsync(x => x.Name.ToUpper().Trim() == newBranch.Name.ToUpper().Trim()
                    && x.OrganizationId == Parameters.OrganizationId))
                {
                    outputDto.Message = outputDto.Message.Length > 0 ? outputDto.Message + ", " + Resource.BRANCH_NAME_IS_EXIST : Resource.BRANCH_NAME_IS_EXIST;
                    outputDto.IdAdded = false;
                }

                if (outputDto.IdAdded)
                {
                    await _uow.BranchRepository.AddAsync(new Branch
                    {
                        Name = newBranch.Name.Trim(),
                        Address = newBranch.Address.Trim(),
                        OrganizationId = Parameters.OrganizationId,
                        AddedDate = DateTime.Now
                    });

                    await _uow.SaveChangesAsync();

                    outputDto.Message = "Successfully added";
                }

                position++;
                Result.Output.AddBranches.Add(outputDto);
            }
        }
    }
}
