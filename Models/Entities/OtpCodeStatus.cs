namespace Models.Entities
{
    public partial class OtpCodeStatus : BaseEntity
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
