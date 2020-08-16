using Models.LogicParameters;
using System.Threading.Tasks;
using Models.LogicParameters.CerificateLogic;

namespace Services.Services.StatisticServices
{
    public interface IStatisticService
    {
        Task<LogicResult<GetCommonStatisticOutput>> GetCommonStatisticAsync();
    }
}
