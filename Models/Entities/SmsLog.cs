using System;

namespace Models.Entities
{
    public partial class SmsLog : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public int PersonId { get; set; }
        public string Phone { get; set; }
        public DateTime SendDate { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
