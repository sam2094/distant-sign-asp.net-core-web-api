using Models.Entities;
using System;

namespace Models.Dtos.BranchDtos
{
    public class GetBranchesDto
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string OrganizationName { get; set; }
		public DateTime AddedDate { get; set; }

		public static implicit operator GetBranchesDto(Branch v)
		{
			return new GetBranchesDto
			{
				Id = v.Id,
				Name = v.Name,
				Address = v.Address,
				OrganizationName = v.Organization.Name,
				AddedDate = v.AddedDate
			};
		}
	}
}
