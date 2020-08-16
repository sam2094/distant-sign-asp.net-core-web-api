using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.UnitofWork;
using Models.Dtos.OrganizationDtos;
using Models.Entities;
using Models.LogicParameters.OrganizationLogic;

namespace BusinessLogic.Logic.OrganizationLogic
{
    public class GetOrganizations : LogicSingleParam<GetOrganizationsOutput>
    {
        public GetOrganizations(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            List<Organization> organizations = _uow.OrganizationRepository.GetAll(i => i.Discount).ToList();
            Result.Output.Organizations = new List<GetOrganizationsDto>(organizations.Select(x => (GetOrganizationsDto)x));
            await Task.CompletedTask;
        }
    }
}
