using System;

namespace Models.Entities
{
    public class Price : BaseEntity
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public byte OperationPriceTypeId { get; set; }
        public byte CertificateTypeId { get; set; }
        public decimal Value { get; set; }
        public DateTime AddedDate { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual OperationPriceType OperationPriceType { get; set; }
        public virtual CertificateType CertificateType { get; set; }
    }
}
