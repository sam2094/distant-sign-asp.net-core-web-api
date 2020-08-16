using Models.Entities;

namespace Models.Dtos.CommonDtos
{
    public class OtpCodeStatusDto
    {
		public byte Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public static implicit operator OtpCodeStatusDto(OtpCodeStatus v)
		{
			return new OtpCodeStatusDto
			{
				Id = v.Id,
				Name = v.Name,
				Description = v.Description
			};
		}
	}
}
