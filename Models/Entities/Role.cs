using System;
using System.Collections.Generic;

namespace Models.Entities
{
	public class Role : BaseEntity
	{
		public Role()
		{
			Users = new HashSet<User>();
			RoleClaims = new HashSet<RoleClaim>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime AddedDate { get; set; }
		public virtual ICollection<User> Users { get; set; }
		public virtual ICollection<RoleClaim> RoleClaims { get; set; }
	}
}
