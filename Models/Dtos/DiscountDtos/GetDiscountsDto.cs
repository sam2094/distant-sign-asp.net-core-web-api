using Models.Entities;

namespace Models.Dtos.DiscountDtos
{
    public class GetDiscountsDto
    {
		public int Id { get; set; }
		public string DiscountTypeName { get; set; }
		public string Name { get; set; }
		public decimal DiscountValue { get; set; }

		public static implicit operator GetDiscountsDto(Discount v)
		{
			return new GetDiscountsDto
			{
				Id = v.Id,
				Name = v.Name,
				DiscountTypeName = v.DiscountType.Name,
				DiscountValue = v.DiscountValue
			};
		}
	}
}
