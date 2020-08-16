using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class UserStatusConfiguration : IEntityTypeConfiguration<UserStatus>
	{
		public void Configure(EntityTypeBuilder<UserStatus> builder)
		{
			builder.ToTable("UserStatuses", "status");

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

			UserStatusSeed.Seed(builder);
		}
	}
}
