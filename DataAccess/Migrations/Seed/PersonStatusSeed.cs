using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class PersonStatusSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<PersonStatus> builder)
        {
            SeedByEnum<PersonStatuses>((value, enm) =>
            {
                builder.HasData(new PersonStatus
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
