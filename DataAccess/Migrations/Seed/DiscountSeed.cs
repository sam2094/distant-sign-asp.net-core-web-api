using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using Common.Enums.DatabaseEnums;

namespace DataAccess.Migrations.Seed
{
    public class DiscountSeed : BaseSeed
    {
		public static void Seed(EntityTypeBuilder<Discount> builder)
		{
			builder.HasData(
				new Discount()
				{
					Id = 1,
					Name = "NO_DISCOUNT",
					DiscountTypeId = (byte)DiscountTypes.PERCENT,
					DiscountValue = 1
				}
			);
		}
	}
}
