using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.ToTable("Employees", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.HasOne(e => e.Organization)
				.WithMany(e => e.Employees)
				.HasForeignKey(e => e.OrganizationId)
				.OnDelete(DeleteBehavior.NoAction);

			//TODO
			builder.HasOne(e => e.Position)
				.WithMany()
				.HasForeignKey(e => e.OrganizationId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.Person)
				.WithMany(e => e.Employees)
				.HasForeignKey(e => e.PersonId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.Certificate)
				.WithMany()
				.HasForeignKey(e => e.CertificateId)
				.OnDelete(DeleteBehavior.NoAction);

			//ClaimSeed.Seed(builder);
		}
	}
}
