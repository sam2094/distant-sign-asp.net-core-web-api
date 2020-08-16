namespace Models.Dtos.CertificateDtos
{
    public class GetCommonStatisticDto
    {
        public decimal CertificateAndSignOperationsTotalPrice { get; set; }
        public decimal CertificatesTotalPrice { get; set; }
        public decimal SignOperationsTotalPrice { get; set; }
        public int CertificatesCount { get; set; }
        public long SignOperationsCount { get; set; }
        public int UsersCount { get; set; }
    }
}
