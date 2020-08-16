using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
	{
		public void Configure(EntityTypeBuilder<Coupon> builder)
		{
			builder.ToTable("Coupons", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.IsUsed)
				.IsRequired();

			builder.Property(e => e.Count)
				.IsRequired();

			builder.Property(e => e.BeginDate)
				.IsRequired();

			builder.Property(e => e.EndDate)
				.IsRequired();

			builder.HasOne(e => e.Discount)
				.WithMany(e => e.Coupons)
				.HasForeignKey(e => e.DiscountId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.Organization)
				.WithMany(e => e.Coupons)
				.HasForeignKey(e => e.OrganizationId)
				.OnDelete(DeleteBehavior.NoAction);

			//TODO
			builder.HasOne(e => e.CertificateType)
				.WithMany()
				.HasForeignKey(e => e.CertificateTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			//ClaimSeed.Seed(builder);
		}
	}
}
