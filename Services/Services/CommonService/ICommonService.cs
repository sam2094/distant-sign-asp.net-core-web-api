using Models.LogicParameters;
using Models.LogicParameters.CommonLogic;
using Models.LogicParameters.DiscountLogic;
using System.Threading.Tasks;

namespace Services.Services.CommonService
{
    public interface ICommonService
    {
        LogicResult<GetLogTypesOutput> GetLogTypes();
        LogicResult<GetOtpCodeStatusesOutput> GetOtpCodeStatuses();
        LogicResult<GetTokenStatusesOutput> GetTokenStatuses();
        Task<LogicResult<GetDiscountsOutput>> GetDiscountsAsync();
        Task<LogicResult<GetDiscountOutput>> GetDiscountAsync(int input);
    }
}
