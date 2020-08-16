using Models.LogicParameters;
using Models.LogicParameters.CertificateLogic;
using System.Threading.Tasks;

namespace Services.Services.CertificateServices
{
    public interface ICertificateService
    {
        LogicResult<GetCertificateStatusesOutput> GetCertificateStatuses();
        LogicResult<GetCertificateTypesOutput> GetCertificateTypes();
        LogicResult<GetDiscountTypesOuput> GetDiscountTypes();
        LogicResult<GetOperationPriceTypesOutput> GetOperationPriceTypes();
    }
}
