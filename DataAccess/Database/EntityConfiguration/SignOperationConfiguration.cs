using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class SignOperationConfiguration : IEntityTypeConfiguration<SignOperation>
	{
		public void Configure(EntityTypeBuilder<SignOperation> builder)
		{
			builder.ToTable("SignOperations", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.FileName)
				.IsRequired()
				.IsUnicode(true);

			builder.Property(e => e.SignSerial)
				.IsRequired()
				.HasMaxLength(100)
				.IsUnicode(true);

			builder.Property(e => e.Price)
				.IsRequired();

			builder.Property(e => e.CalculatedPrice)
				.IsRequired();

			builder.Property(e => e.FileSize)
				.IsRequired();

			builder.Property(e => e.BranchId)
				.IsRequired();

			builder.Property(e => e.UserId)
				.IsRequired();

			builder.Property(e => e.OrganizationId)
				.IsRequired();

			builder.Property(e => e.PersonId)
				.IsRequired();

			builder.Property(e => e.SignedDate)
				.IsRequired();

			builder.Property(e => e.DiscountId)
				.IsRequired();

			builder.Property(e => e.CouponId)
				.IsRequired();

			//ClaimSeed.Seed(builder);
		}
	}
}
