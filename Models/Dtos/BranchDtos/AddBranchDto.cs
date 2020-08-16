using Models.Entities;
using System;

namespace Models.Dtos.BranchDtos
{
    public class AddBranchDto
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public int OrganizationId { get; set; }
		public DateTime AddedDate { get; set; }

		public static implicit operator AddBranchDto(Branch v)
		{
			return new AddBranchDto
			{
				Id = v.Id,
				Name = v.Name,
				Address = v.Address,
				OrganizationId= v.OrganizationId,
				AddedDate = v.AddedDate
			};
		}
	}
}
