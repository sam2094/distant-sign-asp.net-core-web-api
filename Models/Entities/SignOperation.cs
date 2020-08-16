using System;

namespace Models.Entities
{
    /// <summary>
    /// Information about operations (no need relation)
    /// </summary>
    /// 
    public partial class SignOperation : BaseEntity
    {
        public long Id { get; set; }
        public int BranchId { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }
        public int PersonId { get; set; }
        public int DiscountId { get; set; }
        public long CouponId { get; set; }
        public DateTime SignedDate { get; set; }
        public string FileName { get; set; }
        public string SignSerial { get; set; }
        public decimal Price { get; set; }
        public decimal CalculatedPrice { get; set; }
        public int FileSize { get; set; }
    }
}
