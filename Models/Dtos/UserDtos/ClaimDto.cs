using Models.Entities;
using System;

namespace Models.Dtos.UserDtos
{
    public class ClaimDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }

        public static implicit operator ClaimDto(Claim v)
        {
            return new ClaimDto
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description,
                AddedDate = v.AddedDate
            };
        }
    }
}
