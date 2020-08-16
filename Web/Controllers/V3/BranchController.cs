using Services.Services.BranchServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Models.LogicParameters.BranchLogic;
using Common.Enums.DatabaseEnums;
using Web.Filters;

namespace Web.Controllers.V3
{
    public class BranchController : BaseV3Controller
    {
        private readonly IBranchService _branchService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="userService"></param>
        public BranchController(IBranchService branchService) => _branchService = branchService;

        /// <summary>
        ///		
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        [ClaimAuthorize(Claims.CAN_ADD_BRANCH)]
        public async Task<IActionResult> AddBranch(AddBranchInput input)
        {
            return Result(await _branchService.AddBranchAsync(input));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("update")]
        [ClaimAuthorize(Claims.CAN_UPDATE_BRANCH)]
        public async Task<IActionResult> UpdateBranch(UpdateBranchInput input)
        {
            return Result(await _branchService.UpdateBranchAsync(input));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        [ClaimAuthorize(Claims.CAN_GET_BRANCHES)]
        public async Task<IActionResult> GetBranches()
        {
            return Result(await _branchService.GetBranchesAsync());
        }


        /// <summary>
        ///		
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getById/{id}")]
        [ClaimAuthorize(Claims.CAN_GET_BRANCHES)]
        public async Task<IActionResult> GetBranch(int id)
        {
            return Result(await _branchService.GetBranchAsync(id));
        }

        /// <summary>
        ///		
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("addBranches")]
        [ClaimAuthorize(Claims.CAN_ADD_BRANCH)]
        public async Task<IActionResult> AddBranches(AddBranchesInput input)
        {
            return Result(await _branchService.AddBranchesAsync(input));
        }
    }
}
