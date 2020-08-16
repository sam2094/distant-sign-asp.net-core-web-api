using Models.Entities;

namespace Models.Dtos.DiscountDtos
{
    public class GetDiscountDto
    {
		public int Id { get; set; }
		public byte DiscountTypeId { get; set; }
		public string DiscountTypeName { get; set; }
		public string Name { get; set; }
		public decimal DiscountValue { get; set; }

		public static implicit operator GetDiscountDto(Discount v)
		{
			return new GetDiscountDto
			{
				Id = v.Id,
				Name = v.Name,
				DiscountTypeId = v.DiscountTypeId,
				DiscountTypeName = v.DiscountType.Name,
				DiscountValue = v.DiscountValue
			};
		}
	}
}
