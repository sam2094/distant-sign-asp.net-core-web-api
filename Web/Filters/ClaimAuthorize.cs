using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using Models.LogicParameters;
using System.Security.Claims;
using Common;
using Common.Enums.DatabaseEnums;
using Models.LogicParameters.UserLogic;
using Common.Enums.ErrorEnums;
using Common.Resources;
using Web.Helpers;
using Services.Services.UserServices;

namespace Web.Filters
{
	public class ClaimAuthorize : Attribute, IAuthorizationFilter
	{
		private readonly Claims _claim;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="claim"></param>
		public ClaimAuthorize() { }
		public ClaimAuthorize(Claims claim)
		{
			_claim = claim;
		}

		public void OnAuthorization(AuthorizationFilterContext context)
		{
			IUserService userService = context.HttpContext.RequestServices.GetService<IUserService>();
			int id = Convert.ToInt32(context.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value);

			if (!userService.Authorization(new AuthorizationInput
			{
				ClaimId = (int)_claim,
				CurrentUserId = id
			}).Result.IsSuccess)
			{
				context.Result = new CreateActionResult<LogicOutput>(new LogicResult<LogicOutput>
				{
					ErrorList = new List<Error>
					  {
						 new Error
						 {
							 ErrorCode = ErrorCodes.UNAUTHORIZED,
							 StatusCode = ErrorHttpStatus.UNAUTHORIZED,
							 ErrorMessage = Resource.UNAUTHORIZED
						 }
					  }
				})

				{
					StatusCode = (int)HttpStatusCode.Unauthorized
				};
			}
		}
	}
}
