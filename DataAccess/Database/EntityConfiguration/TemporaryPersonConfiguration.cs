using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class TemporaryPersonConfiguration : IEntityTypeConfiguration<TemporaryPerson>
	{
		public void Configure(EntityTypeBuilder<TemporaryPerson> builder)
		{
			builder.ToTable("TemporaryPersons", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Pin)
				.IsRequired()
				.HasMaxLength(20)
				.IsUnicode(true);

			builder.Property(e => e.PersonTypeId)
				   .IsRequired();

			builder.Property(e => e.OrganizationId)
				   .IsRequired();

			builder.Property(e => e.AddedDate)
				   .IsRequired();
			
			//ClaimSeed.Seed(builder);
		}
	}
}
