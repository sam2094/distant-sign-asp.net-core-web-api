using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class CertificateStatusConfiguration : IEntityTypeConfiguration<CertificateStatus>
	{
		public void Configure(EntityTypeBuilder<CertificateStatus> builder)
		{
			builder.ToTable("CertificateStatuses", "status");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Description)
				.IsRequired()
				.HasMaxLength(250)
				.IsUnicode(true);

			CertificateStatusSeed.Seed(builder);
		}
	}
}
