using BusinessLogic.Logic.OrganizationLogic;
using DataAccess.UnitofWork;
using Models.LogicParameters;
using Models.LogicParameters.OrganizationLogic;
using System.Threading.Tasks;

namespace Services.Services.OrganizationServices
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IUnitOfWork _uow;
        public OrganizationService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<LogicResult<AddOrganizationOutput>> AddOrganizationAsync(AddOrganizationInput input)
         => await new AddOrganization(_uow, nameof(AddOrganizationAsync)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<UpdateOrganizationOutput>> UpdateOrganizationAsync(UpdateOrganizationInput input)
         => await new UpdateOrganization(_uow, nameof(UpdateOrganizationAsync)).ExecuteAsync(parameters: input);

        public async Task<LogicResult<GetOrganizationsOutput>> GetOrganizationsAsync()
         => await new GetOrganizations(_uow, nameof(GetOrganizationsAsync)).ExecuteAsync();

        public async Task<LogicResult<GetOrganizationOutput>> GetOrganizationAsync(int input)
         => await new GetOrganization(_uow, nameof(GetOrganizationAsync)).ExecuteAsync(input);

        public async Task<LogicResult<GetStatisticsByOrganizationOutput>> GetStatisticsByOrganizationAsync(int input)
         => await new GetStatisticsByOrganization(_uow, nameof(GetStatisticsByOrganizationAsync)).ExecuteAsync(input);
    }
}
