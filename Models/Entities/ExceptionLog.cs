using System;

namespace Models.Entities
{
	public class ExceptionLog : BaseEntity
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Content { get; set; }
		public DateTime AddedDate { get; set; }
	}
}
