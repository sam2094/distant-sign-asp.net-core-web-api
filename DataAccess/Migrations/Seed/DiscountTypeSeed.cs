using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class DiscountTypeSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<DiscountType> builder)
        {
            SeedByEnum<DiscountTypes>((value, enm) =>
            {
                builder.HasData(new DiscountType
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
