using Services.Services.CertificateServices;
using Microsoft.AspNetCore.Mvc;
using Common.Enums.DatabaseEnums;
using Web.Filters;

namespace Web.Controllers.V3
{
    public class CertificateController : BaseV3Controller
    {
        private readonly ICertificateService _certificateService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="certificateService"></param>
        public CertificateController(ICertificateService certificateService) => _certificateService = certificateService;

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getStatuses")]
        [ClaimAuthorize(Claims.CAN_GET_CERTIFICATE_STATUSES)]
        public IActionResult GetCertificateStatuses()
        {
            return Result(_certificateService.GetCertificateStatuses());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getTypes")]
        [ClaimAuthorize(Claims.CAN_GET_CERTIFICATE_TYPES)]
        public IActionResult GetCertificateTypes()
        {
            return Result(_certificateService.GetCertificateTypes());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getDiscountTypes")]
        [ClaimAuthorize(Claims.CAN_GET_DISCOUNT_TYPES)]
        public IActionResult GetDiscountTypes()
        {
            return Result(_certificateService.GetDiscountTypes());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getOperationPriceTypes")]
        [ClaimAuthorize(Claims.CAN_GET_OPERATION_PRICE_TYPES)]
        public IActionResult GetOperationPriceTypes()
        {
            return Result(_certificateService.GetOperationPriceTypes());
        }
    }
}
