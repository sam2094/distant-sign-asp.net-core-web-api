using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
	{
		public void Configure(EntityTypeBuilder<Organization> builder)
		{
			builder.ToTable("Organizations", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Account)
				.IsRequired()
				.IsUnicode(true);

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Voen)
				.IsRequired()
				.HasMaxLength(20)
				.IsUnicode(false);

			builder.Property(e => e.AddedDate)
			   .IsRequired();

			// TODO
			builder.HasOne(e => e.Discount)
				.WithMany()
				.HasForeignKey(e => e.DiscountId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasMany(e => e.Branches)
				.WithOne(e => e.Organization)
				.HasForeignKey(e => e.OrganizationId);

			builder.HasMany(e => e.Prices)
			   .WithOne(e => e.Organization)
			   .HasForeignKey(e => e.OrganizationId);

			builder.HasMany(e => e.Employees)
			   .WithOne(e => e.Organization)
			   .HasForeignKey(e => e.OrganizationId);

			builder.HasMany(e => e.Coupons)
			   .WithOne(e => e.Organization)
			   .HasForeignKey(e => e.OrganizationId);

			builder.HasMany(e => e.Certificates)
			   .WithOne(e => e.Organization)
			   .HasForeignKey(e => e.OrganizationId);

			OrganizationSeed.Seed(builder);
		}
	}
}
