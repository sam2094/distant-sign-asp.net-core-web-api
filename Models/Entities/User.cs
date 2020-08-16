namespace Models.Entities
{
	using System;
	using System.Collections.Generic;

	public partial class User : BaseEntity
	{
		public User()
		{
			BranchesUsers = new HashSet<BranchUser>();
			Tokens = new HashSet<Token>();
		}

		public int Id { get; set; }
		public int RoleId { get; set; }
		public byte StatusId { get; set; }
		public byte GenderTypeId { get; set; }
		public byte CitizenTypeId { get; set; }
		public string Pin { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Username { get; set; }
		public byte[] Password { get; set; }
		public byte[] Salt { get; set; }
		public DateTime AddedDate { get; set; }
		public DateTime LastLoginDate { get; set; }
		public virtual Role Role { get; set; }
		public virtual UserStatus Status { get; set; }
		public virtual GenderType GenderType { get; set; }
		public virtual CitizenType CitizenType { get; set; }

		/// <summary>
		/// For finding previous branches (for statistics, normally getting last branch )
		/// </summary>
		public virtual ICollection<BranchUser> BranchesUsers { get; set; }
		public virtual ICollection<Token> Tokens { get; set; }
	}
}
