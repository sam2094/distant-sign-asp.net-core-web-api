using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using Web.Helpers;
using Models.LogicParameters;

namespace Web.Filters
{
	public class ValidationFilter : IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext context) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		public void OnActionExecuting(ActionExecutingContext context)
		{
			if (context.ActionArguments.Any(x => x.Value == null))
			{
				context.Result = new CreateActionResult<LogicOutput>(new LogicResult<LogicOutput>()
				{
					ErrorList = new List<Error>
					{
						new Error
						{
							ErrorCode = ErrorCodes.INPUT_IS_NOT_VALID,
							ErrorMessage = Resource.INVALID_INPUT,
							StatusCode = ErrorHttpStatus.VALIDATION
						}
					}
				});
				return;
			}

			if (context.ModelState.IsValid) return;

			List<Error> errors = context.ModelState.Select(keyValuePair => new Error
			{
				ErrorCode = ErrorCodes.INPUT_IS_NOT_VALID,
				ErrorMessage = keyValuePair.Value.Errors.FirstOrDefault(x => x.ErrorMessage != string.Empty)?.ErrorMessage ?? Resource.INVALID_INPUT,
				StatusCode = ErrorHttpStatus.VALIDATION
			}).ToList();

			context.Result = new CreateActionResult<LogicOutput>(new LogicResult<LogicOutput>()
			{
				ErrorList = errors
			});
		}
	}
}
