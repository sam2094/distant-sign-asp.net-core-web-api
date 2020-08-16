using Common.Attributes;
using Common.Enums.DatabaseEnums;
using Common.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;

namespace DataAccess.Migrations.Seed
{
	public class RoleSeed : BaseSeed
	{
		public static void Seed(EntityTypeBuilder<Role> builder)
		{
			DateTime date = DateTime.Now;

			SeedByEnum<Roles>((value, enm) =>
			{
				builder.HasData(new Role
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
