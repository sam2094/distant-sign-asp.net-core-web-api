using Models.Entities;
using System;

namespace Models.Dtos.OrganizationDtos
{
    public class AddOrganizationDto
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public string Name { get; set; }
        public string Voen { get; set; }
        public int Account { get; set; }
        public DateTime AddedDate { get; set; }

        public static implicit operator AddOrganizationDto(Organization v)
        {
            return new AddOrganizationDto
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
