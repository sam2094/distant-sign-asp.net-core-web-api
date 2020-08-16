using System;

namespace Models.Entities
{
    public class TemporaryPerson : BaseEntity
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public int PersonTypeId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
