namespace Models.Entities
{
    public partial class PersonStatus:BaseEntity
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
