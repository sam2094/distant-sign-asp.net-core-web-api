using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
	{
		public void Configure(EntityTypeBuilder<Certificate> builder)
		{
			builder.ToTable("Certificates", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.AuthCertThumbPrint)
				.IsRequired()
				.HasMaxLength(100)
				.IsUnicode(false);

			builder.Property(e => e.AuthCertSerialNumber)
				.IsRequired()
				.HasMaxLength(100)
				.IsUnicode(false);

			builder.Property(e => e.SignCertThumbPrint)
				.IsRequired()
				.HasMaxLength(100)
				.IsUnicode(false);

			builder.Property(e => e.SignCertSerialNumber)
				.IsRequired()
				.HasMaxLength(100)
				.IsUnicode(false);

			builder.Property(e => e.Price)
				.IsRequired();

			builder.Property(e => e.AddedDate)
				.IsRequired();

			builder.Property(e => e.ExpireDate)
				.IsRequired();

			// TODO one-to-one
			builder.HasOne(e => e.PinCode)
				.WithOne(e => e.Certificate)
				.HasForeignKey<PinCode>(x => x.CertificateId)
				.OnDelete(DeleteBehavior.NoAction);

			// TODO
			builder.HasOne(e => e.CertificateStatus)
				.WithMany()
				.HasForeignKey(e => e.CertificateStatusId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.CertificateType)
				.WithMany()
				.HasForeignKey(e => e.CertificateTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.Person)
				.WithMany(e => e.Certificates)
				.HasForeignKey(e => e.PersonId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.Organization)
				.WithMany(e => e.Certificates)
				.HasForeignKey(e => e.OrganizationId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasMany(e => e.OtpCodes)
			   .WithOne(e => e.Certificate)
			   .HasForeignKey(e => e.CertificateId);

			CertificateSeed.Seed(builder);
		}
	}
}
