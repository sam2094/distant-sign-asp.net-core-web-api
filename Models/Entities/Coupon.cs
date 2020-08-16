using System;

namespace Models.Entities
{
    public class Coupon : BaseEntity
    {
        public long Id { get; set; }
        public int DiscountId { get; set; }
        public int OrganizationId { get; set; }
        public byte CertificateTypeId { get; set; }
        public bool IsUsed { get; set; }
        public int Count { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual CertificateType CertificateType { get; set; }
    }
}
