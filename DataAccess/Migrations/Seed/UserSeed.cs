using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Helpers;
using Models.Entities;
using System;
using Common.Enums.DatabaseEnums;

namespace DataAccess.Migrations.Seed
{
	public class UserSeed : BaseSeed
	{
		public static void Seed(EntityTypeBuilder<User> builder)
		{
			byte[] salt = Hashing.RandomSalt();
			DateTime date = DateTime.Now;

			builder.HasData(
				new User()
				{
					Id = 1,
					FullName = "Samir Hasanov",
					Username = "a",
					Pin = "60LWSJG",
					PhoneNumber = "11111",
					RoleId = (int)Roles.SUPER_ADMIN,
					StatusId = (byte)UserStatuses.ACTIVE,
					GenderTypeId = (byte)GenderTypes.MALE,
					CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
					Salt = salt,
					Password = Hashing.Hash(salt, "a"),
					AddedDate = date,
					LastLoginDate = date,
				},

				new User()
				{
					Id = 2,
					FullName = "Ramiz Aliyev",
					Username = "b",
					Pin = "70YWUJP",
					PhoneNumber = "22222",
					RoleId = (int)Roles.ORG_ADMIN,
					StatusId = (byte)UserStatuses.ACTIVE,
					GenderTypeId = (byte)GenderTypes.MALE,
					CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
					Salt = salt,
					Password = Hashing.Hash(salt, "a"),
					AddedDate = date,
					LastLoginDate = date,
				},

				new User()
				{
					Id = 3,
					FullName = "Aydan Memmedova",
					Username = "c",
					Pin = "70YWUJP",
					PhoneNumber = "33333",
					RoleId = (int)Roles.MANAGER,
					StatusId = (byte)UserStatuses.ACTIVE,
					GenderTypeId = (byte)GenderTypes.FEMALE,
					CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
					Salt = salt,
					Password = Hashing.Hash(salt, "a"),
					AddedDate = date,
					LastLoginDate = date,
				},
				new User()
				{
					Id = 4,
					FullName = "Kamil Huseynov",
					Username = "d",
					Pin = "70YWUJP",
					PhoneNumber = "444444",
					RoleId = (int)Roles.OPERATOR,
					StatusId = (byte)UserStatuses.ACTIVE,
					GenderTypeId = (byte)GenderTypes.MALE,
					CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
					Salt = salt,
					Password = Hashing.Hash(salt, "a"),
					AddedDate = date,
					LastLoginDate = date,
				},
				new User()
				{
					Id = 5,
					FullName = "Rauf Quliyev",
					Username = "e",
					Pin = "70YWUJP",
					PhoneNumber = "555555",
					RoleId = (int)Roles.SELLER,
					StatusId = (byte)UserStatuses.ACTIVE,
					GenderTypeId = (byte)GenderTypes.MALE,
					CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
					Salt = salt,
					Password = Hashing.Hash(salt, "a"),
					AddedDate = date,
					LastLoginDate = date,
				},
				new User()
				{
					Id = 6,
					FullName = "Nermin Rzayeva",
					Username = "f",
					Pin = "70YWUJP",
					PhoneNumber = "666666",
					RoleId = (int)Roles.MANAGER,
					StatusId = (byte)UserStatuses.ACTIVE,
					GenderTypeId = (byte)GenderTypes.FEMALE,
					CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
					Salt = salt,
					Password = Hashing.Hash(salt, "a"),
					AddedDate = date,
					LastLoginDate = date,
				}
			);
		}
	}
}
