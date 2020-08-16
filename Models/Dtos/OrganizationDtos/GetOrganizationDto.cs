using System;
using Models.Entities;

namespace Models.Dtos.OrganizationDtos
{
    public class GetOrganizationDto
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public string Name { get; set; }
        public string Voen { get; set; }
        public int Account { get; set; }
        public DateTime AddedDate { get; set; }

        public static implicit operator GetOrganizationDto(Organization v)
        {
            return new GetOrganizationDto
            {
                Id = v.Id,
                Name = v.Name,
                Voen = v.Voen,
                Account = v.Account,
                DiscountId = v.DiscountId,
                DiscountName = v.Discount.Name,
                AddedDate = v.AddedDate
            };
        }
    }
}
