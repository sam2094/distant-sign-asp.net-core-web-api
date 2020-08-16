using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Enums.DatabaseEnums;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Dtos.OrganizationDtos;
using Models.Entities;
using Models.LogicParameters.OrganizationLogic;

namespace BusinessLogic.Logic.OrganizationLogic
{
    public class GetStatisticsByOrganization : Logic<int, GetStatisticsByOrganizationOutput>
    {
        public GetStatisticsByOrganization(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            Organization organization = await _uow.OrganizationRepository.GetAsync(x => x.Id == Parameters);

            if (organization == null)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.ORGANIZATION_DOES_NOT_EXIST,
                    ErrorMessage = Resource.ORGANIZATION_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.NOT_FOUND
                });
                return;
            }

            Result.Output.OrganizationStatistics = new GetStatisticsByOrganizationDto();

            Result.Output.OrganizationStatistics.OrganizationName = organization.Name;
            Result.Output.OrganizationStatistics.Voen = organization.Voen;

            Result.Output.OrganizationStatistics.AllCertificateCount = await _uow.CertificateRepository.CountAsync(x => x.OrganizationId == Parameters);

            Result.Output.OrganizationStatistics.AllCertificateTotalPrice = _uow.CertificateRepository.GetAll(x => x.OrganizationId == Parameters)
            .Sum(i => i.Price);

            Result.Output.OrganizationStatistics.AllSignOperationsCount = await _uow.SignOperationRepository.CountAsync(x => x.OrganizationId == Parameters);

            Result.Output.OrganizationStatistics.AllSignOperationsTotalPrice = _uow.SignOperationRepository.GetAll(x => x.OrganizationId == Parameters)
            .Sum(i => i.Price);

            Result.Output.OrganizationStatistics.CitizenCertificateCount = await _uow.CertificateRepository.CountAsync(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.CITIZEN);

            Result.Output.OrganizationStatistics.CitizenCertificatePrice = _uow.CertificateRepository.GetAll(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.CITIZEN).Sum(x => x.Price);

            Result.Output.OrganizationStatistics.LegalCertificateCount = await _uow.CertificateRepository.CountAsync(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.LEGAL);

            Result.Output.OrganizationStatistics.LegalCertificatePrice = _uow.CertificateRepository.GetAll(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.LEGAL).Sum(x => x.Price);

            Result.Output.OrganizationStatistics.GovernmentCertificateCount = await _uow.CertificateRepository.CountAsync(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.GOVERNMENT);

            Result.Output.OrganizationStatistics.GovernmentCertificatePrice = _uow.CertificateRepository.GetAll(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.GOVERNMENT).Sum(x => x.Price);

            Result.Output.OrganizationStatistics.OwnerCertificateCount = await _uow.CertificateRepository.CountAsync(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.OWNER);

            Result.Output.OrganizationStatistics.OwnerCertificatePrice = _uow.CertificateRepository.GetAll(x => x.OrganizationId == Parameters
            && x.CertificateTypeId == (byte)CertificateTypes.OWNER).Sum(x => x.Price);

            Result.Output.OrganizationStatistics.BranchesCount = await _uow.BranchRepository.CountAsync(x => x.OrganizationId == Parameters);

            Result.Output.OrganizationStatistics.UsersCount = _uow.GetRepository<BranchUser>().GetAll(x => x.Branch.OrganizationId == Parameters, i => i.Branch).Count();
        }
    }
}


