using Models.Dtos.OrganizationDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.OrganizationLogic
{
    public class GetOrganizationsOutput : LogicOutput
    {
        public List<GetOrganizationsDto> Organizations { get; set; }
    }
}
