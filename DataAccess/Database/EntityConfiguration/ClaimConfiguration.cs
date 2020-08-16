using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class ClaimConfiguration : IEntityTypeConfiguration<Claim>
	{
		public void Configure(EntityTypeBuilder<Claim> builder)
		{
			builder.ToTable("Claims", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(false);

			builder.Property(e => e.AddedDate)
				.IsRequired();

			builder.Property(e => e.Description)
				.IsRequired()
				.HasMaxLength(250)
				.IsUnicode(true);

			ClaimSeed.Seed(builder);
		}
	}
}
