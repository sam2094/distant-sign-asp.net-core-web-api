using Models.Entities;
using System;

namespace Models.Dtos.OrganizationDtos
{
   public class GetOrganizationsDto
    {
		public int Id { get; set; }
		public string DiscountName { get; set; }
		public string Name { get; set; }
		public string Voen { get; set; }
		public int Account { get; set; }
		public DateTime AddedDate { get; set; }

		public static implicit operator GetOrganizationsDto(Organization v)
		{
			return new GetOrganizationsDto
			{
				Id = v.Id,
				Name = v.Name,
				Voen = v.Voen,
				Account = v.Account,
				DiscountName = v.Discount.Name,
				AddedDate = v.AddedDate
			};
		}
	}
}
