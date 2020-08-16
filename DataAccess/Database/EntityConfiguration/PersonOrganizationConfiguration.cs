using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	class PersonOrganizationConfiguration : IEntityTypeConfiguration<PersonOrganization>
	{
		public void Configure(EntityTypeBuilder<PersonOrganization> builder)
		{
			builder.ToTable("PersonsOrganizations", "dbo");

			builder.HasKey(e => new { e.PersonId, e.OrganizationId });

			builder.HasOne(e => e.Person)
				 .WithMany(e => e.PersonOrganizations)
				 .HasForeignKey(e => e.PersonId);
			//.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.Organization)
				 .WithMany(e => e.PersonOrganizations)
				 .HasForeignKey(e => e.OrganizationId);
				 //.OnDelete(DeleteBehavior.NoAction);

			//TODO
			builder.HasOne(e => e.BranchUser)
				 .WithMany()
				 .HasForeignKey(e => e.BranchUserId);

			//RoleClaimSeed.Seed(builder);
		}
	}
}
