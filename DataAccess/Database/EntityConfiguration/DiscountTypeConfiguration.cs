using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class DiscountTypeConfiguration : IEntityTypeConfiguration<DiscountType>
	{
		public void Configure(EntityTypeBuilder<DiscountType> builder)
		{
			builder.ToTable("DiscountTypes", "type");

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

			DiscountTypeSeed.Seed(builder);
		}
	}
}
