using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;
namespace DataAccess.Database.EntityConfiguration
{
	public class ChangesLogConfiguration : IEntityTypeConfiguration<ChangesLog>
	{
		public void Configure(EntityTypeBuilder<ChangesLog> builder)
		{
			builder.ToTable("ChangesLogs", "log");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.LogTypeId)
				.IsRequired();

			builder.Property(e => e.UserId)
				.IsRequired();

			builder.Property(e => e.BranchId)
				.IsRequired();

			builder.Property(e => e.PersonId)
				.IsRequired();

			builder.Property(e => e.ChangedDate)
				.IsRequired();

			builder.Property(e => e.From)
				.IsRequired()
				.IsUnicode(true);

			builder.Property(e => e.To)
				.IsRequired()
				.IsUnicode(true);

			builder.Property(e => e.Price)
				.IsRequired();

			//ClaimSeed.Seed(builder);
		}
	}
}
