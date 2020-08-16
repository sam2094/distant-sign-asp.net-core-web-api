using Common;
using Common.Enums.ErrorEnums;
using System.Collections.Generic;
using System.Linq;

namespace Models.LogicParameters
{
	public class LogicResult<TOutput> where TOutput : LogicOutput
	{
		public TOutput Output { get; set; }
		public List<Error> ErrorList { get; set; } = new List<Error>();
		public bool IsSuccess => ErrorList.All(e => e.StatusCode == ErrorHttpStatus.SUCCESS);
	}
}
