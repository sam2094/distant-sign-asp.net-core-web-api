using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class OperationPriceTypeSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<OperationPriceType> builder)
        {
            SeedByEnum<OperationPriceTypes>((value, enm) =>
            {
                builder.HasData(new OperationPriceType
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
