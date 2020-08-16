namespace Models.Entities
{
	public class Employee : BaseEntity
	{
		public int Id { get; set; }
		public int OrganizationId { get; set; }
		public int PersonId { get; set; }
		public int PositionId { get; set; }
		public int CertificateId { get; set; }
		public byte StatusId { get; set; }

		public virtual Organization Organization { get; set; }
		public virtual Certificate Certificate { get; set; }
		public virtual Position Position { get; set; }
		public virtual Person Person { get; set; }
	}
}
