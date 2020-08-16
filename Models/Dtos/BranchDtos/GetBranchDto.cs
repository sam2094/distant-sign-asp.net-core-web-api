using Models.Entities;
using System;

namespace Models.Dtos.BranchDtos
{
    public class GetBranchDto
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public int OrganizationId { get; set; }
		public string OrganizationName { get; set; }
		public DateTime AddedDate { get; set; }

		public static implicit operator GetBranchDto(Branch v)
		{
			return new GetBranchDto
			{
				Id = v.Id,
				Name = v.Name,
				Address = v.Address,
				OrganizationId = v.OrganizationId,
				OrganizationName = v.Organization.Name,
				AddedDate = v.AddedDate
			};
		}
	}
}
