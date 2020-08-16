using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class OtpCodeConfiguration : IEntityTypeConfiguration<OtpCode>
	{
		public void Configure(EntityTypeBuilder<OtpCode> builder)
		{
			builder.ToTable("OtpCodes", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Value)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.AddedDate)
				   .IsRequired();

			builder.HasOne(e => e.Certificate)
				.WithMany(e => e.OtpCodes)
				.HasForeignKey(e => e.CertificateId)
				.OnDelete(DeleteBehavior.NoAction);

			// TODO
			builder.HasOne(e => e.OtpCodeStatus)
				.WithMany()
				.HasForeignKey(e => e.OtpCodeStatusId)
				.OnDelete(DeleteBehavior.NoAction);

			//ClaimSeed.Seed(builder);
		}
	}
}
