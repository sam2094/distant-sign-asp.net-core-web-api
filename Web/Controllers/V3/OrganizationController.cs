using Services.Services.OrganizationServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Models.LogicParameters.OrganizationLogic;
using Common.Enums.DatabaseEnums;
using Web.Filters;

namespace Web.Controllers.V3
{
    public class OrganizationController : BaseV3Controller
    {
        private readonly IOrganizationService _organizationService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="userService"></param>
        public OrganizationController(IOrganizationService organizationService) => _organizationService = organizationService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        [ClaimAuthorize(Claims.CAN_ADD_ORGANIZATION)]
        public async Task<IActionResult> AddOrganization(AddOrganizationInput input)
        {
            return Result(await _organizationService.AddOrganizationAsync(input));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("update")]
        [ClaimAuthorize(Claims.CAN_UPDATE_ORGANIZATION)]
        public async Task<IActionResult> UpdateOrganization(UpdateOrganizationInput input)
        {
            return Result(await _organizationService.UpdateOrganizationAsync(input));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        [ClaimAuthorize(Claims.CAN_GET_ORGANIZATIONS)]
        public async Task<IActionResult> GetOrganizations()
        {
            return Result(await _organizationService.GetOrganizationsAsync());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getById/{id}")]
        [ClaimAuthorize(Claims.CAN_GET_ORGANIZATIONS)]
        public async Task<IActionResult> GetOrganization(int id)
        {
            return Result(await _organizationService.GetOrganizationAsync(id));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getStatisticsByOrganization/{id}")]
        [ClaimAuthorize(Claims.CAN_GET_STATISTIC_BY_ORGANIZATION)]
        public async Task<IActionResult> GetStatisticsByOrganization(int id)
        {
            return Result(await _organizationService.GetStatisticsByOrganizationAsync(id));
        }
    }
}
