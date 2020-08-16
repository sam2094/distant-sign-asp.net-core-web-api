using BusinessLogic.Logic.CertificateLogic;
using DataAccess.UnitofWork;
using Models.LogicParameters;
using Models.LogicParameters.CertificateLogic;
using System.Threading.Tasks;

namespace Services.Services.CertificateServices
{
    public class CertificateService : ICertificateService
    {
        private readonly IUnitOfWork _uow;

        public CertificateService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public LogicResult<GetCertificateStatusesOutput> GetCertificateStatuses()
            => new GetCertificateStatuses(_uow, nameof(GetCertificateStatuses)).Execute();

        public LogicResult<GetCertificateTypesOutput> GetCertificateTypes()
            => new GetCertificateTypes(_uow, nameof(GetCertificateTypes)).Execute();

        public LogicResult<GetDiscountTypesOuput> GetDiscountTypes()
            => new GetDiscountTypes(_uow, nameof(GetDiscountTypes)).Execute();

        public LogicResult<GetOperationPriceTypesOutput> GetOperationPriceTypes()
            => new GetOperationPriceTypes(_uow, nameof(GetOperationPriceTypes)).Execute();
    }
}
