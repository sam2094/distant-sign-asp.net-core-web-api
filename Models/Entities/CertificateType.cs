namespace Models.Entities
{
    public class CertificateType : BaseEntity
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
