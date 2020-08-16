using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class OtpCodeStatusSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<OtpCodeStatus> builder)
        {
            SeedByEnum<OtpCodeStatuses>((value, enm) =>
            {
                builder.HasData(new OtpCodeStatus
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
