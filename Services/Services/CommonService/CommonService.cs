using DataAccess.UnitofWork;
using Models.LogicParameters;
using Models.LogicParameters.CommonLogic;
using BusinessLogic.Logic.CommonLogic;
using System.Threading.Tasks;
using Models.LogicParameters.DiscountLogic;
using BusinessLogic.Logic.DiscountLogic;

namespace Services.Services.CommonService
{
    public class CommonService : ICommonService
    {
        private readonly IUnitOfWork _uow;

        public CommonService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<LogicResult<GetDiscountOutput>> GetDiscountAsync(int input)
         => await new GetDiscount(_uow, nameof(GetDiscountAsync)).ExecuteAsync(input);

        public async Task<LogicResult<GetDiscountsOutput>> GetDiscountsAsync()
         => await new GetDiscounts(_uow, nameof(GetDiscountsAsync)).ExecuteAsync();

        public LogicResult<GetLogTypesOutput> GetLogTypes()
         => new GetLogTypes(_uow, nameof(GetLogTypes)).Execute();

        public LogicResult<GetOtpCodeStatusesOutput> GetOtpCodeStatuses()
         => new GetOtpCodeStatuses(_uow, nameof(GetOtpCodeStatuses)).Execute();

        public LogicResult<GetTokenStatusesOutput> GetTokenStatuses()
         => new GetTokenStatuses(_uow, nameof(GetTokenStatuses)).Execute();
    }
}
