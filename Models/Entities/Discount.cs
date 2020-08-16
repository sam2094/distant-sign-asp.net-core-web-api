using System.Collections.Generic;

namespace Models.Entities
{
    public class Discount : BaseEntity
    {
        public Discount()
        {
            Coupons = new HashSet<Coupon>();
            OrganizationDiscounts = new HashSet<OrganizationDiscount>();
        }

        public int Id { get; set; }
        public byte DiscountTypeId { get; set; }
        public string Name { get; set; }
        public decimal DiscountValue { get; set; }

        public virtual DiscountType DiscountType { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<OrganizationDiscount> OrganizationDiscounts { get; set; }

    }
}
