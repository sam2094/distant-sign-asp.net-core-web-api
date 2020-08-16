using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Services.Services.UserServices;
using Models.LogicParameters.UserLogic;
using Common.Enums.DatabaseEnums;
using Web.Filters;
using System;
using System.Linq;
using System.Security.Claims;
using Web.Extensions;

namespace Web.Controllers.V3
{
    public class UserController : BaseV3Controller
    {
        private readonly IUserService _userService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService) => _userService = userService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Authenticate(AuthenticateInputDto inputDto)
        {
            AuthenticateInput input = (AuthenticateInput) inputDto;
            return Result(await _userService.Authenticate(input));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getcurrentuser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            return Result(await _userService.GetCurrentUser(new GetCurrentUserInput().Authorized(HttpContext)));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getGenderTypes")]
        [ClaimAuthorize(Claims.CAN_GET_GENDER_TYPES)]
        public IActionResult GetGenderTypes()
        {
            return Result(_userService.GetGenderTypes());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getUserStatuses")]
        [ClaimAuthorize(Claims.CAN_GET_USER_STATUSES)]
        public IActionResult GetUserStatuses()
        {
            return Result(_userService.GetUserStatuses());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getCitizenTypes")]
        [ClaimAuthorize(Claims.CAN_GET_CITIZEN_TYPES)]
        public IActionResult GetCitizenTypes()
        {
            return Result(_userService.GetCitizenTypes());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getPersonStatuses")]
        [ClaimAuthorize(Claims.CAN_GET_PERSON_STATUSES)]
        public IActionResult GetPersonStatuses()
        {
            return Result(_userService.GetPersonStatuses());
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getClaims")]
        [ClaimAuthorize(Claims.CAN_GET_CLAIMS)]
        public async Task<IActionResult> GetClaims()
        {
            return Result( await _userService.GetClaims(Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value)));
        }


        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getRoles")]
        [ClaimAuthorize(Claims.CAN_GET_ROLES)]
        public async Task<IActionResult> GetRoles()
        {
            return Result(await _userService.GetRoles(Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value)));
        }

        #region Uncompleted Services (Registration and GetUserById)
        /// <summary>
        ///		
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //[HttpPost]
        //[Route("register")]
        //public async Task<IActionResult> UserRegister(UserRegisterInputDto inputDto)
        //{
        //    UserRegisterInput input = (UserRegisterInput) inputDto;
        //    return Result(await _userService.UserRegister(input.Authorized(HttpContext)));
        //}

        /// <summary>
        ///		
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        //[HttpGet]
        //[Route("getById/{userId}")]
        //[ClaimAuthorize(Claims.CAN_GET_USER_BY_ID)]
        //public async Task<IActionResult> GetUserById(int userId)
        //{

        //    GetUserByIdInput input = new GetUserByIdInput
        //    {
        //        UserId = userId
        //    };

        //    return Result(await _userService.GetUserById(input.Authorized(HttpContext)));
        //}
        #endregion
    }
}
