using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class ExceptionLogConfiguration : IEntityTypeConfiguration<ExceptionLog>
	{
		public void Configure(EntityTypeBuilder<ExceptionLog> builder)
		{
			builder.ToTable("ExceptionLogs", "log");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(200)
				.IsUnicode(true);

			builder.Property(e => e.Content)
				.IsRequired()
				.IsUnicode(true);

			builder.Property(e => e.AddedDate)
				.IsRequired();

			//ClaimSeed.Seed(builder);
		}
	}
}
