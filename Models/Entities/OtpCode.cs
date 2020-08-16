using System;

namespace Models.Entities
{
    
    public partial class OtpCode  :BaseEntity
    {
        public int Id { get; set; }
        public int CertificateId { get; set; }
        public byte OtpCodeStatusId { get; set; }
        public string Value { get; set; }
        public DateTime AddedDate { get; set; }
    
        public virtual Certificate Certificate { get; set; }
        public virtual OtpCodeStatus OtpCodeStatus { get; set; }
    }
}
