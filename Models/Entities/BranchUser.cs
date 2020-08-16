using System;

namespace Models.Entities
{
	public partial class BranchUser : BaseEntity
	{
		public int Id { get; set; }
		public int BranchId { get; set; }
		public int UserId { get; set; }
		public DateTime AddedDate { get; set; }
		public virtual Branch Branch { get; set; }
		public virtual User User { get; set; }
	}
}
