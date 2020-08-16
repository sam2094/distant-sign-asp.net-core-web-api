using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class CitizenTypeSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<CitizenType> builder)
        {
            SeedByEnum<CitizenTypes>((value, enm) =>
            {
                builder.HasData(new CitizenType
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
