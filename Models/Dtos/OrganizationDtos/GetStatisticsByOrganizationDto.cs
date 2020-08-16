namespace Models.Dtos.OrganizationDtos
{
    public class GetStatisticsByOrganizationDto
    {
        public string OrganizationName { get; set; }
        public string Voen { get; set; }
        public int AllCertificateCount { get; set; }
        public decimal AllCertificateTotalPrice { get; set; }
        public int AllSignOperationsCount { get; set; }
        public decimal AllSignOperationsTotalPrice { get; set; }
        public int CitizenCertificateCount { get; set; }
        public decimal CitizenCertificatePrice { get; set; }
        public int LegalCertificateCount { get; set; }
        public decimal LegalCertificatePrice { get; set; }
        public int GovernmentCertificateCount { get; set; }
        public decimal GovernmentCertificatePrice { get; set; }
        public int OwnerCertificateCount { get; set; }
        public decimal OwnerCertificatePrice { get; set; }
        public int BranchesCount { get; set; }
        public int UsersCount { get; set; }
    }
}
