using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.ToTable("Roles", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Description)
				.HasMaxLength(150)
				.IsUnicode(true);

			builder.Property(e => e.AddedDate)
				.IsRequired(true);

			builder.HasMany(e => e.Users)
				.WithOne(e => e.Role)
				.HasForeignKey(e => e.RoleId);

			RoleSeed.Seed(builder);
		}
	}
}
