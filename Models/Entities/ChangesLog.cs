using System;

namespace Models.Entities
{
    public partial class ChangesLog : BaseEntity
    {
        public int Id { get; set; }
        public byte LogTypeId { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public int PersonId { get; set; }
        public DateTime ChangedDate { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Price { get; set; }
    }
}
