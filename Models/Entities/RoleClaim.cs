namespace Models.Entities
{
	public class RoleClaim : BaseEntity
	{
		public int RoleId { get; set; }
		public virtual Role Role { get; set; }
		public int ClaimId { get; set; }
		public virtual Claim Claim { get; set; }
	}
}
