using Models.LogicParameters;
using Models.LogicParameters.OrganizationLogic;
using System.Threading.Tasks;

namespace Services.Services.OrganizationServices
{
    public interface IOrganizationService
    {
        Task<LogicResult<AddOrganizationOutput>> AddOrganizationAsync(AddOrganizationInput input);
        Task<LogicResult<UpdateOrganizationOutput>> UpdateOrganizationAsync(UpdateOrganizationInput input);
        Task<LogicResult<GetOrganizationsOutput>> GetOrganizationsAsync();
        Task<LogicResult<GetOrganizationOutput>> GetOrganizationAsync(int input);
        Task<LogicResult<GetStatisticsByOrganizationOutput>> GetStatisticsByOrganizationAsync(int input);
    }
}
