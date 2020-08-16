using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using Models.Entities;
using Common.Enums.DatabaseEnums;

namespace DataAccess.Migrations.Seed
{
	class RoleClaimSeed : BaseSeed
	{
		public static void Seed(EntityTypeBuilder<RoleClaim> builder)
		{
			List<RoleClaim> roleClaims = new List<RoleClaim>();
			List<Claims> claims = Enum.GetValues(typeof(Claims)).Cast<Claims>().ToList();

			claims.ForEach(item =>
			{
				roleClaims.Add(new RoleClaim
				{
					RoleId = (int)Roles.SUPER_ADMIN,
					ClaimId = (int)item
				});
			});

			claims.Where(x => x == Claims.CAN_GET_USER_BY_ID 
			|| x == Claims.CAN_GET_CITIZEN_TYPES
			|| x == Claims.CAN_GET_GENDER_TYPES
			|| x == Claims.CAN_GET_USER_STATUSES
			|| x == Claims.CAN_GET_CLAIMS
			|| x == Claims.CAN_GET_TOKEN_STATUSES
			|| x == Claims.CAN_GET_ROLES
			|| x == Claims.CAN_GET_COMMON_STATISTICS
			|| x == Claims.CAN_GET_STATISTIC_BY_ORGANIZATION
			).ToList()
			.ForEach(item =>
			{
				roleClaims.Add(new RoleClaim
				{
					RoleId = (int)Roles.ORG_ADMIN,
					ClaimId = (int)item
				});
			});

			claims.Where(x => x == Claims.CAN_GET_USER_BY_ID
			|| x == Claims.CAN_GET_CITIZEN_TYPES
			|| x == Claims.CAN_GET_GENDER_TYPES
			|| x == Claims.CAN_GET_USER_STATUSES
			|| x == Claims.CAN_GET_CLAIMS
			).ToList()
			.ForEach(item =>
			{
				roleClaims.Add(new RoleClaim
				{
					RoleId = (int)Roles.MANAGER,
					ClaimId = (int)item
				});
			});

			builder.HasData(roleClaims);
		}
	}
}
