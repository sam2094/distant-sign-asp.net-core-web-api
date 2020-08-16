using System;
using System.Collections.Generic;

namespace Models.Entities
{
	public class Claim : BaseEntity
	{
		public Claim()
		{
			RoleClaims = new HashSet<RoleClaim>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime AddedDate { get; set; }
		public virtual ICollection<RoleClaim> RoleClaims { get; set; }

	}
}
