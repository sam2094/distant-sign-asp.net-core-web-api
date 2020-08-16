using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class GenderTypeSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<GenderType> builder)
        {
            SeedByEnum<GenderTypes>((value, enm) =>
            {
                builder.HasData(new GenderType
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
