using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
	{
		public void Configure(EntityTypeBuilder<RoleClaim> builder)
		{
			builder.ToTable("RolesClaims", "dbo");

			builder.HasKey(e => new { e.RoleId, e.ClaimId });

			builder.HasOne(e => e.Role)
				 .WithMany(e => e.RoleClaims)
				 .HasForeignKey(e => e.RoleId);

			builder.HasOne(e => e.Claim)
				 .WithMany(e => e.RoleClaims)
				 .HasForeignKey(e => e.ClaimId);

			RoleClaimSeed.Seed(builder);
		}
	}
}
