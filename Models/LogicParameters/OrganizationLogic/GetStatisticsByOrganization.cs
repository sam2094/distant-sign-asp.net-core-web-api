using Models.Dtos.OrganizationDtos;

namespace Models.LogicParameters.OrganizationLogic
{
    public class GetStatisticsByOrganizationOutput : LogicOutput
    {
        public GetStatisticsByOrganizationDto OrganizationStatistics { get; set; }
    }
}
