using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class OrganizationDiscountConfiguration : IEntityTypeConfiguration<OrganizationDiscount>
	{
		public void Configure(EntityTypeBuilder<OrganizationDiscount> builder)
		{
			builder.ToTable("OrganizationsDiscounts", "dbo");

			builder.HasKey(e => new { e.OrganizationId, e.DiscountId });

			builder.HasOne(e => e.Organization)
				 .WithMany(e => e.OrganizationDiscounts)
				 .HasForeignKey(e => e.OrganizationId);
				 //.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.Discount)
				 .WithMany(e => e.OrganizationDiscounts)
				 .HasForeignKey(e => e.DiscountId);
				 //.OnDelete(DeleteBehavior.NoAction);

			builder.Property(e => e.BeginDate)
				.IsRequired();

			builder.Property(e => e.EndDate)
				.IsRequired();

			//RoleClaimSeed.Seed(builder);
		}
	}
}
