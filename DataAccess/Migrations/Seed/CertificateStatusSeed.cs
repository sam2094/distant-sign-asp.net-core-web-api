using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class CertificateStatusSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<CertificateStatus> builder)
        {
            SeedByEnum<CertificateStatuses>((value, enm) =>
            {
                builder.HasData(new CertificateStatus
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
