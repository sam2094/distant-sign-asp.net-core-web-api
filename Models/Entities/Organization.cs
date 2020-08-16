using System;
using System.Collections.Generic;

namespace Models.Entities
{
	public partial class Organization : BaseEntity
	{
		public Organization()
		{
			Branches = new HashSet<Branch>();
			Prices = new HashSet<Price>();
			Employees = new HashSet<Employee>();
			Coupons = new HashSet<Coupon>();
			OrganizationDiscounts = new HashSet<OrganizationDiscount>();
			PersonOrganizations = new HashSet<PersonOrganization>();
		}

		public int Id { get; set; }
		public int DiscountId { get; set; }
		public string Name { get; set; }
		public string Voen { get; set; }
		public int Account { get; set; }
		public DateTime AddedDate { get; set; }
		public virtual Discount Discount { get; set; }
		public virtual ICollection<Branch> Branches { get; set; }
		public virtual ICollection<Price> Prices { get; set; }
		public virtual ICollection<Coupon> Coupons { get; set; }
		public virtual ICollection<Employee> Employees { get; set; }
		public virtual ICollection<OrganizationDiscount> OrganizationDiscounts { get; set; }
		public virtual ICollection<PersonOrganization> PersonOrganizations { get; set; }
		public virtual ICollection<Certificate> Certificates { get; set; }

	}
}
