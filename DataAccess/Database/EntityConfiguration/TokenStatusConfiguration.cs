using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class TokenStatusConfiguration : IEntityTypeConfiguration<TokenStatus>
	{
		public void Configure(EntityTypeBuilder<TokenStatus> builder)
		{
			builder.ToTable("TokenStatuses", "status");

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

			TokenStatusSeed.Seed(builder);
		}
	}
}
