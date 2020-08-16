using Services.Services.StatisticServices;
using Microsoft.AspNetCore.Mvc;
using Common.Enums.DatabaseEnums;
using Web.Filters;
using System.Threading.Tasks;

namespace Web.Controllers.V3
{
    public class StatisticController : BaseV3Controller
    {
        private readonly IStatisticService _statisticService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="certificateService"></param>
        public StatisticController(IStatisticService statisticService) => _statisticService = statisticService;

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getCommonStatistics")]
        [ClaimAuthorize(Claims.CAN_GET_COMMON_STATISTICS)]
        public async Task<IActionResult> GetDiscounts()
        {
            return Result(await _statisticService.GetCommonStatisticAsync());
        }
    }
}
