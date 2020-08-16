using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class PersonConfiguration : IEntityTypeConfiguration<Person>
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.ToTable("Persons", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Pin)
			  .IsRequired()
			  .HasMaxLength(20)
			  .IsUnicode(false);

			builder.Property(e => e.Serial)
			  .IsRequired()
			  .HasMaxLength(20)
			  .IsUnicode(false);

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Surname)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode(true);

			builder.Property(e => e.Patronymic)
			   .IsRequired()
			   .HasMaxLength(50)
			   .IsUnicode(true);

			builder.Property(e => e.Phone)
			  .IsRequired()
			  .HasMaxLength(20)
			  .IsUnicode(false);

			builder.Property(e => e.Email)
			  .IsRequired()
			  .HasMaxLength(50)
			  .IsUnicode(false);

			builder.Property(e => e.AddedDate)
			   .IsRequired();

			// TODO
			builder.HasOne(e => e.CitizenType)
				.WithMany()
				.HasForeignKey(e => e.CitizenTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.GenderType)
				.WithMany()
				.HasForeignKey(e => e.GenderTypeId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(e => e.PersonStatus)
				.WithMany()
				.HasForeignKey(e => e.PersonStatusId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasMany(e => e.Certificates)
			   .WithOne(e => e.Person)
			   .HasForeignKey(e => e.PersonId);

			builder.HasMany(e => e.Employees)
			   .WithOne(e => e.Person)
			   .HasForeignKey(e => e.PersonId);

            PersonSeed.Seed(builder);
        }
	}
}
