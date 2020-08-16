using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
   public class UserStatusSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<UserStatus> builder)
        {
            SeedByEnum<UserStatuses>((value, enm) =>
            {
                builder.HasData(new UserStatus
                {
                    Id = (byte)enm,
                    Name = enm.ToString(),
                    Description = enm.GetAttribute<EnumDescription>().Description,
                });
            });
        }
    }
}
