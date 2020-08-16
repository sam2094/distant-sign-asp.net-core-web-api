using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Models.Entities;

namespace DataAccess.Migrations.Seed
{
	public class ClaimSeed : BaseSeed
	{
		public static void Seed(EntityTypeBuilder<Claim> builder)
		{
			DateTime date = DateTime.Now;

			SeedByEnum<Claims>((value, enm) =>
			{
				builder.HasData(new Claim
				{
					Id = (int)enm,
					Name = enm.ToString(),
					Description = enm.GetAttribute<EnumDescription>().Description,
					AddedDate = date
				});
			});
		}
	}
}
