using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class CertificateTypeSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<CertificateType> builder)
        {
            SeedByEnum<CertificateTypes>((value, enm) =>
            {
                builder.HasData(new CertificateType
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
