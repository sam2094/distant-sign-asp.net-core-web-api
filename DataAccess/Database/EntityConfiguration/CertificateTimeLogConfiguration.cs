using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;
namespace DataAccess.Database.EntityConfiguration
{
	public class CertificateTimeLogConfiguration : IEntityTypeConfiguration<CertificateTimeLog>
	{
		public void Configure(EntityTypeBuilder<CertificateTimeLog> builder)
		{
			builder.ToTable("CertificateTimeLogs", "log");

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
