using Models.Entities;

namespace Models.Dtos.UserDtos
{
    public class PersonStatusDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator PersonStatusDto(PersonStatus v)
        {
            return new PersonStatusDto
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description
            };
        }
    }
}
