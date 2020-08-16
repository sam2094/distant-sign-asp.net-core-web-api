namespace Models.Entities
{
    public partial class PersonOrganization : BaseEntity
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        public int BranchUserId { get; set; }
        public virtual BranchUser BranchUser { get; set; }
    }
}
