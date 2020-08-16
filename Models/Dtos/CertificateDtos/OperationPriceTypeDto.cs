using Models.Entities;

namespace Models.Dtos.CertificateDtos
{
    public class OperationPriceTypeDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator OperationPriceTypeDto(OperationPriceType v)
        {
            return new OperationPriceTypeDto
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description
            };
        }
    }
}
