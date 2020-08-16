using Models.Entities;

namespace Models.Dtos.CommonDtos
{
    public class TokenStatusDto
    {
		public byte Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public static implicit operator TokenStatusDto(TokenStatus v)
		{
			return new TokenStatusDto
			{
				Id = v.Id,
				Name = v.Name,
				Description = v.Description
			};
		}
	}
}
