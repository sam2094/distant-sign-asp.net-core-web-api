using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Migrations.Seed;
using Models.Entities;

namespace DataAccess.Database.EntityConfiguration
{
	public class TokenConfiguration : IEntityTypeConfiguration<Token>
	{
		public void Configure(EntityTypeBuilder<Token> builder)
		{
			builder.ToTable("Tokens", "dbo");

			builder.Property(e => e.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.Property(e => e.ExpireDate)
				   .IsRequired();

			builder.HasOne(e => e.User)
				.WithMany(e => e.Tokens)
				.HasForeignKey(e => e.UserId)
				.OnDelete(DeleteBehavior.NoAction);

			// TODO
			builder.HasOne(e => e.TokenStatus)
				.WithMany()
				.HasForeignKey(e => e.TokenStatusId)
				.OnDelete(DeleteBehavior.NoAction);

			//ClaimSeed.Seed(builder);
		}
	}
}
