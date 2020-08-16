using Microsoft.AspNetCore.Mvc;
using Models.LogicParameters;
using Web.Helpers;

namespace Web.Controllers
{
	[ApiController]
	public class BaseController : ControllerBase
	{
		public CreateActionResult<TResult> Result<TResult>(LogicResult<TResult> result) where TResult : LogicOutput
		{
			return new CreateActionResult<TResult>(result);
		}
	}
}
