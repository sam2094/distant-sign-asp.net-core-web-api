namespace Models.Entities
{
    public partial class PinCode : BaseEntity
    {
        // TODO one to one relation

        public int Id { get; set; }
        public string Value { get; set; }
        public int CertificateId { get; set; }
        public virtual Certificate Certificate { get; set; }
    }
}
