using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("Users", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Pin)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(false);

			builder.Property(e => e.FullName)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Username)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.PhoneNumber)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Password)
				.IsRequired();

			builder.Property(e => e.Salt)
				.IsRequired();

			builder.Property(e => e.AddedDate)
				.IsRequired();

			builder.Property(e => e.LastLoginDate)
				.IsRequired();

			builder.HasOne(e => e.Role)
				.WithMany(e => e.Users)
				.HasForeignKey(e => e.RoleId)
				.OnDelete(DeleteBehavior.NoAction);

			// TODO
			builder.HasOne(e => e.Status)
				.WithMany()
				.HasForeignKey(e => e.StatusId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.GenderType)
				.WithMany()
				.HasForeignKey(e => e.GenderTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.CitizenType)
				.WithMany()
				.HasForeignKey(e => e.CitizenTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasMany(e => e.BranchesUsers)
				.WithOne(e => e.User)
				.HasForeignKey(e => e.UserId);

			builder.HasMany(e => e.Tokens)
				.WithOne(e => e.User)
				.HasForeignKey(e => e.UserId);

			UserSeed.Seed(builder);
		}
	}
}
