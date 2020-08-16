using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DataAccess.Repositories.CertificateRepository
{
    public class SignOperationRepository : GenericRepository<SignOperation>, ISignOperationRepository
    {
        public SignOperationRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
