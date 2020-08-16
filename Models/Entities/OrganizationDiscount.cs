using System;

namespace Models.Entities
{
    public class OrganizationDiscount
    {
        public int OrganizationId { get; set; }
        public int DiscountId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
