using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class BranchUserConfiguration : IEntityTypeConfiguration<BranchUser>
	{
		public void Configure(EntityTypeBuilder<BranchUser> builder)
		{
			builder.ToTable("BranchUsers", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.AddedDate)
				.IsRequired();

			builder.HasOne(e => e.Branch)
				.WithMany(e => e.BranchesUsers)
				.HasForeignKey(e => e.BranchId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.User)
				.WithMany(e => e.BranchesUsers)
				.HasForeignKey(e => e.UserId)
				.OnDelete(DeleteBehavior.NoAction);

			BranchUserSeed.Seed(builder);
		}
	}
}
