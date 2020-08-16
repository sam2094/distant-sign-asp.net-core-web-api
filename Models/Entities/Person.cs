using System;
using System.Collections.Generic;

namespace Models.Entities
{
	public partial class Person : BaseEntity
	{
		public Person()
		{
			Certificates = new HashSet<Certificate>();
			PersonOrganizations = new HashSet<PersonOrganization>();
		}

		public int Id { get; set; }
		public byte CitizenTypeId { get; set; }
		public byte GenderTypeId { get; set; }
		public byte PersonStatusId { get; set; }
		public string Pin { get; set; }
		public string Serial { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Patronymic { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public DateTime AddedDate { get; set; }
		public virtual CitizenType CitizenType { get; set; }
		public virtual GenderType GenderType { get; set; }
		public virtual PersonStatus PersonStatus { get; set; }
		public virtual ICollection<Certificate> Certificates { get; set; }
		public virtual ICollection<PersonOrganization> PersonOrganizations { get; set; }
		public virtual ICollection<Employee> Employees { get; set; }
	}
}
