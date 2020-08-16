using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class PinCodeConfiguration : IEntityTypeConfiguration<PinCode>
	{
		public void Configure(EntityTypeBuilder<PinCode> builder)
		{
			builder.ToTable("PinCodes", "dbo");

			builder.Property(e => e.Id)
				.IsRequired();

			builder.Property(e => e.Value)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			//ClaimSeed.Seed(builder);
		}
	}
}
