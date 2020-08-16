using System;
using System.Collections.Generic;

namespace Models.Entities
{
	public partial class Certificate : BaseEntity
	{
		public Certificate()
		{
			OtpCodes = new HashSet<OtpCode>();
		}

		public int Id { get; set; }
		public int PersonId { get; set; }
		public int OrganizationId { get; set; }
		public byte CertificateStatusId { get; set; }
		public byte CertificateTypeId { get; set; }
		public string AuthCertThumbPrint { get; set; }
		public string AuthCertSerialNumber { get; set; }
		public string SignCertThumbPrint { get; set; }
		public string SignCertSerialNumber { get; set; }
		public decimal Price { get; set; }
		public DateTime AddedDate { get; set; }
		public DateTime ExpireDate { get; set; }
		public virtual Person Person { get; set; }
		public virtual Organization Organization { get; set; }
		public virtual CertificateStatus CertificateStatus { get; set; }
		public virtual CertificateType CertificateType { get; set; }
		public virtual PinCode PinCode { get; set; }
		public virtual ICollection<OtpCode> OtpCodes { get; set; }
	}
}
