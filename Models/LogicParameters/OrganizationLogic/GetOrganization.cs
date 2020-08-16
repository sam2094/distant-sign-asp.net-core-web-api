using Models.Dtos.OrganizationDtos;

namespace Models.LogicParameters.OrganizationLogic
{
    public class GetOrganizationOutput : LogicOutput
    {
        public GetOrganizationDto Organization { get; set; }
    }
}
