using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class LogTypeConfiguration : IEntityTypeConfiguration<LogType>
	{
		public void Configure(EntityTypeBuilder<LogType> builder)
		{
			builder.ToTable("LogTypes", "type");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Name)
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Description)
				.HasMaxLength(250)
				.IsUnicode(true);

			LogTypeSeed.Seed(builder);
		}
	}
}
