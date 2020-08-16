using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class PriceConfiguration : IEntityTypeConfiguration<Price>
	{
		public void Configure(EntityTypeBuilder<Price> builder)
		{
			builder.ToTable("Prices", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Value)
				   .IsRequired();

			builder.Property(e => e.AddedDate)
				   .IsRequired();

			builder.HasOne(e => e.Organization)
				.WithMany( e => e.Prices)
				.HasForeignKey(e => e.OrganizationId)
				.OnDelete(DeleteBehavior.NoAction);

			// TODO
			builder.HasOne(e => e.OperationPriceType)
				.WithMany()
				.HasForeignKey(e => e.OperationPriceTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.CertificateType)
				.WithMany()
				.HasForeignKey(e => e.CertificateTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			//ClaimSeed.Seed(builder);
		}
	}
}
