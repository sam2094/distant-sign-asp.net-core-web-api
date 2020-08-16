using Models.Entities;
using System;

namespace Models.Dtos.UserDtos
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }

        public static implicit operator RoleDto(Role v)
        {
            return new RoleDto
            {
                Id = v.Id,
                Name = v.Name,
                Description = v.Description,
                AddedDate = v.AddedDate
            };
        }
    }
}
