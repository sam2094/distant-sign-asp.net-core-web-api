using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
	{
		public void Configure(EntityTypeBuilder<Discount> builder)
		{
			builder.ToTable("Discounts", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.DiscountValue)
				.IsRequired();

			builder.HasMany(e => e.Coupons)
			   .WithOne(e => e.Discount)
			   .HasForeignKey(e => e.DiscountId);

			//TODO
			builder.HasOne(e => e.DiscountType)
				.WithMany()
				.HasForeignKey(e => e.DiscountTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			DiscountSeed.Seed(builder);
		}
	}
}
