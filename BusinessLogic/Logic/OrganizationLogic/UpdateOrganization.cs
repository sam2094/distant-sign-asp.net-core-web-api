using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.OrganizationLogic;

namespace BusinessLogic.Logic.OrganizationLogic
{
    public class UpdateOrganization : Logic<UpdateOrganizationInput, UpdateOrganizationOutput>
    {
        public UpdateOrganization(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = true) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            Organization organization = await _uow.OrganizationRepository.GetAsync(x => x.Id == Parameters.OrganizationId);

            if (organization == null)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.ORGANIZATION_DOES_NOT_EXIST,
                    ErrorMessage = Resource.ORGANIZATION_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.NOT_FOUND
                });
                return;
            }

            if (await _uow.OrganizationRepository.IsExistAsync(x => x.Name.ToUpper().Trim() == Parameters.Name.ToUpper().Trim() && x.Id != organization.Id))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.ORGANIZATION_NAME_IS_EXIST,
                    ErrorMessage = Resource.ORGANIZATION_NAME_IS_EXIST,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            if (await _uow.OrganizationRepository.IsExistAsync(x => x.Voen.ToUpper().Trim() == Parameters.Voen.ToUpper().Trim() && x.Id != organization.Id))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.VOEN_IS_EXIST,
                    ErrorMessage = Resource.VOEN_IS_EXIST,
                    StatusCode = ErrorHttpStatus.FORBIDDEN
                });
                return;
            }

            if (!await _uow.DiscountRepository.IsExistAsync(x => x.Id == Parameters.DiscountId))
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.DISCOUNT_DOES_NOT_EXIST,
                    ErrorMessage = Resource.DISCOUNT_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.NOT_FOUND
                });
                return;
            }

            organization.Name = Parameters.Name.Trim();
            organization.Voen = Parameters.Voen.Trim();
            organization.Account = Parameters.Account;
            organization.DiscountId = Parameters.DiscountId;

            await _uow.SaveChangesAsync();

            Organization org = await _uow.OrganizationRepository.GetAsync(x => x.Id == organization.Id, i => i.Discount);

            Result.Output.Organization = org;
        }
    }

}
