using Models.Entities;

namespace Models.Dtos.CertificateDtos
{
    public class CertificateStatusDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

		public static implicit operator CertificateStatusDto(CertificateStatus v)
		{
			return new CertificateStatusDto
			{
				Id = v.Id,
				Name = v.Name,
				Description = v.Description
			};
		}
	}
}
