using Models.Entities;

namespace Models.Dtos.CertificateDtos
{
    public class CertificateTypeDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator CertificateTypeDto(CertificateType v)
        {
            return new CertificateTypeDto
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description
            };
        }
    }
}
