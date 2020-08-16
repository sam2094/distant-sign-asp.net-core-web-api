using System;
using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.OrganizationLogic;

namespace BusinessLogic.Logic.OrganizationLogic
{
    public class AddOrganization : Logic<AddOrganizationInput, AddOrganizationOutput>
    {
        public AddOrganization(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = true) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {

            if (await _uow.OrganizationRepository.IsExistAsync(x => x.Name.ToUpper().Trim() == Parameters.Name.ToUpper().Trim()))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.ORGANIZATION_NAME_IS_EXIST,
                    ErrorMessage = Resource.ORGANIZATION_NAME_IS_EXIST,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            if (await _uow.OrganizationRepository.IsExistAsync(x => x.Voen.ToUpper().Trim() == Parameters.Voen.ToUpper().Trim()))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.VOEN_IS_EXIST,
                    ErrorMessage = Resource.VOEN_IS_EXIST,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            if (Parameters.DiscountId != 0 && !await _uow.DiscountRepository.IsExistAsync(x => x.Id == Parameters.DiscountId))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.DISCOUNT_DOES_NOT_EXIST,
                    ErrorMessage = Resource.DISCOUNT_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.NOT_FOUND
                });
                return;
            }

            Organization organization = new Organization
            {
                Name = Parameters.Name.Trim(),
                Voen = Parameters.Voen.Trim(),
                Account = Parameters.Account,
                DiscountId = Parameters.DiscountId == 0 ? 1 : Parameters.DiscountId, // 1 equal NO_DISCOUNT
                AddedDate = DateTime.Now
            };

            await _uow.OrganizationRepository.AddAsync(organization);
            await _uow.SaveChangesAsync();

           Organization org =  await _uow.OrganizationRepository.GetAsync(x => x.Id == organization.Id, i => i.Discount);


            Result.Output.Organization = org;
        }
    }
}