using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class BranchConfiguration : IEntityTypeConfiguration<Branch>
	{
		public void Configure(EntityTypeBuilder<Branch> builder)
		{
			builder.ToTable("Branches", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Address)
				.IsRequired()
				.HasMaxLength(250)
				.IsUnicode(true);

			builder.Property(e => e.AddedDate)
				   .IsRequired();

			builder.HasOne(e => e.Organization)
				.WithMany(e => e.Branches)
				.HasForeignKey(e => e.OrganizationId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasMany(e => e.BranchesUsers)
				.WithOne(e => e.Branch)
				.HasForeignKey(e => e.BranchId);

			BranchSeed.Seed(builder);
		}
	}
}
