using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class TokenStatusSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<TokenStatus> builder)
        {
            SeedByEnum<TokenStatuses>((value, enm) =>
            {
                builder.HasData(new TokenStatus
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
