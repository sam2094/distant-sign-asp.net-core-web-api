using System.Linq;
using System.Threading.Tasks;
using DataAccess.UnitofWork;
using Models.Dtos.CertificateDtos;
using Models.LogicParameters.CerificateLogic;

namespace BusinessLogic.Logic.StatisticsLogic
{
    public class GetCommonStatistic : LogicSingleParam<GetCommonStatisticOutput>
    {
        public GetCommonStatistic(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            Result.Output.CommonStatistics = new GetCommonStatisticDto();

            Result.Output.CommonStatistics.CertificateAndSignOperationsTotalPrice = _uow.CertificateRepository.GetAll().Sum(i => i.Price)
                + _uow.SignOperationRepository.GetAll().Sum(i => i.Price);

            Result.Output.CommonStatistics.CertificatesTotalPrice = _uow.CertificateRepository.GetAll().Sum(i => i.Price);

            Result.Output.CommonStatistics.SignOperationsTotalPrice = _uow.SignOperationRepository.GetAll().Sum(i => i.Price);

            Result.Output.CommonStatistics.CertificatesCount = await _uow.CertificateRepository.CountAsync();

            Result.Output.CommonStatistics.SignOperationsCount = await _uow.SignOperationRepository.CountAsync();

            Result.Output.CommonStatistics.UsersCount = await _uow.UserRepository.CountAsync();
        }
    }
}
