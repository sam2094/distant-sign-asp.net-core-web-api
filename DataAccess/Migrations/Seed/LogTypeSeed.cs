using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
    public class LogTypeSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<LogType> builder)
        {
            SeedByEnum<LogTypes>((value, enm) =>
            {
                builder.HasData(new LogType
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
