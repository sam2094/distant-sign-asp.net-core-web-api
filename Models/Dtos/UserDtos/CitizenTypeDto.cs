using Models.Entities;

namespace Models.Dtos.UserDtos
{
    public class CitizenTypeDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator CitizenTypeDto(CitizenType v)
        {
            return new CitizenTypeDto
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description
            };
        }
    }
}
