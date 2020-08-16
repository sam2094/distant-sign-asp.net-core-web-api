using Models.Entities;
using System;

namespace Models.Dtos.UserDtos
{
	public class UserDto
	{
		public int Id { get; set; }
		public string Fullname { get; set; }
		public string Pin { get; set; }
		public DateTime AddedDate { get; set; }
		public DateTime LastLoginDate { get; set; }

		public static implicit operator UserDto(User v)
		{
			return new UserDto
			{
				Id = v.Id,
				Fullname = v.FullName,
				Pin = v.Pin,
				AddedDate = v.AddedDate,
				LastLoginDate = v.LastLoginDate
			};
		}
	}
}
