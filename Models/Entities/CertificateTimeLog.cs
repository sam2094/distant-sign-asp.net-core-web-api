using System;

namespace Models.Entities
{
	public class CertificateTimeLog : BaseEntity
	{
		public int Id { get; set; }
		public string Pin { get; set; }
		public DateTime RequestBegin { get; set; }
		public DateTime RequestEnd { get; set; }
		public DateTime IamasBegin { get; set; }
		public DateTime IamasEnd { get; set; }
		public DateTime RACABegin { get; set; }
		public DateTime RACAEnd { get; set; }
		public DateTime PersonalizationBegin { get; set; }
		public DateTime PersonalizationEnd { get; set; }
		public DateTime SmsBegin { get; set; }
		public DateTime SmsEnd { get; set; }
		public double TotalRequestTime { get; set; }
		public double IamasTime { get; set; }
		public double RACATime { get; set; }
		public double PersonalizationTime { get; set; }
		public double SmsTime { get; set; }
		public string Guid { get; set; }
	}
}
