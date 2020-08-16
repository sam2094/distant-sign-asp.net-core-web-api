using System;
using System.Collections.Generic;

namespace Models.Entities
{
	public partial class Branch : BaseEntity
	{
		public Branch()
		{
			BranchesUsers = new HashSet<BranchUser>();
			SignOperations = new HashSet<SignOperation>();
		}

		public int Id { get; set; }
		public int OrganizationId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public DateTime AddedDate { get; set; }

		public virtual Organization Organization { get; set; }
		public virtual ICollection<BranchUser> BranchesUsers { get; set; }
		public virtual ICollection<SignOperation> SignOperations { get; set; }
	}
}
