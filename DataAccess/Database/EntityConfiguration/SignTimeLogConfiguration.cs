using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class SignTimeLogConfiguration : IEntityTypeConfiguration<SignTimeLog>
	{
		public void Configure(EntityTypeBuilder<SignTimeLog> builder)
		{
			builder.ToTable("SignTimeLogs", "log");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Pin)
				.IsRequired()
				.HasMaxLength(20)
				.IsUnicode(false);

			//ClaimSeed.Seed(builder);
		}
	}
}
