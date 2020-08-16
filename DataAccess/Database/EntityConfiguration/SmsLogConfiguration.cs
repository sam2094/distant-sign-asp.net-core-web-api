using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class SmsLogConfiguration : IEntityTypeConfiguration<SmsLog>
	{
		public void Configure(EntityTypeBuilder<SmsLog> builder)
		{
			builder.ToTable("SmsLogs", "log");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.UserId)
				.IsRequired();

			builder.Property(e => e.PersonId)
				.IsRequired();

			builder.Property(e => e.SendDate)
				.IsRequired();

			builder.Property(e => e.Phone)
				.IsRequired()
				.HasMaxLength(20)
				.IsUnicode(false);

			// TODO
			builder.HasOne(e => e.Branch)
				.WithMany()
				.HasForeignKey(e => e.BranchId)
				.OnDelete(DeleteBehavior.NoAction);

			//ClaimSeed.Seed(builder);
		}
	}
}
