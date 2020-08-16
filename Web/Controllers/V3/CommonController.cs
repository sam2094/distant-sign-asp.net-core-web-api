using Services.Services.CommonService;
using Microsoft.AspNetCore.Mvc;
using Common.Enums.DatabaseEnums;
using Web.Filters;
using System.Threading.Tasks;

namespace Web.Controllers.V3
{
    public class CommonController : BaseV3Controller
    {
        private readonly ICommonService _commonService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="certificateService"></param>
        public CommonController(ICommonService commonService) => _commonService = commonService;

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getLogTypes")]
        [ClaimAuthorize(Claims.CAN_GET_LOG_TYPES)]
        public IActionResult GetLogTypes()
        {
            return Result(_commonService.GetLogTypes());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getOtpCodeStatuses")]
        [ClaimAuthorize(Claims.CAN_GET_OTP_CODE_STATUSES)]
        public IActionResult GetOtpCodeStatuses()
        {
            return Result(_commonService.GetOtpCodeStatuses());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getTokenStatuses")]
        [ClaimAuthorize(Claims.CAN_GET_TOKEN_STATUSES)]
        public IActionResult GetTokenStatuses()
        {
            return Result(_commonService.GetTokenStatuses());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getDiscounts")]
        [ClaimAuthorize(Claims.CAN_GET_DISCOUNTS)]
        public async Task<IActionResult> GetDiscounts()
        {
            return Result( await _commonService.GetDiscountsAsync());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getDiscountById/{id}")]
        [ClaimAuthorize(Claims.CAN_GET_DISCOUNTS)]
        public async Task<IActionResult> GetDiscounts(int id)
        {
            return Result(await _commonService.GetDiscountAsync(id));
        }
    }
}
