using DataAccess.UnitofWork;
using Models.LogicParameters;
using System.Threading.Tasks;
using Models.LogicParameters.CerificateLogic;
using BusinessLogic.Logic.StatisticsLogic;

namespace Services.Services.StatisticServices
{
    public class StatisticService : IStatisticService
    {
        private readonly IUnitOfWork _uow;

        public StatisticService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<LogicResult<GetCommonStatisticOutput>> GetCommonStatisticAsync()
           => await new GetCommonStatistic(_uow, nameof(GetCommonStatisticAsync)).ExecuteAsync();
    }
}
