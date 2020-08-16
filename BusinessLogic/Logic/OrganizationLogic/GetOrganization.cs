using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.OrganizationLogic;

namespace BusinessLogic.Logic.OrganizationLogic
{
    public class GetOrganization : Logic<int, GetOrganizationOutput>
    {
        public GetOrganization(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            Organization organization = await _uow.OrganizationRepository.GetAsync(x => x.Id == Parameters, i => i.Discount);

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

            Result.Output.Organization = organization;
        }
    }
}
