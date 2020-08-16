using Models.Entities;

namespace Models.Dtos.UserDtos
{
    public class UserStatusDto
    {
		public byte Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public static implicit operator UserStatusDto(UserStatus v)
		{
			return new UserStatusDto
			{
				Id = v.Id,
				Name = v.Name,
				Description = v.Description
			};
		}
	}
}
