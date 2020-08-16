using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class CertificateTypeConfiguration : IEntityTypeConfiguration<CertificateType>
	{
		public void Configure(EntityTypeBuilder<CertificateType> builder)
		{
			builder.ToTable("CertificateTypes", "type");

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

			CertificateTypeSeed.Seed(builder);
		}
	}
}
