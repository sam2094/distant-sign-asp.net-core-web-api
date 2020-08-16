using Models.Entities;

namespace Models.Dtos.CertificateDtos
{
    public class DiscountTypeDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator DiscountTypeDto(DiscountType v)
        {
            return new DiscountTypeDto
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description
            };
        }
    }
}
