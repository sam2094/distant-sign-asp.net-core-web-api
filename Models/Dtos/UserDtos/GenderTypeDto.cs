using Models.Entities;

namespace Models.Dtos.UserDtos
{
    public class GenderTypeDto
    {
		public byte Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public static implicit operator GenderTypeDto(GenderType v)
		{
			return new GenderTypeDto
			{
				Id = v.Id,
				Name = v.Name,
				Description = v.Description
			};
		}
	}
}
