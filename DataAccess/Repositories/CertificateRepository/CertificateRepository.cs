using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DataAccess.Repositories.CertificateRepository
{
    public class CertificateRepository : GenericRepository<Certificate>, ICertificateRepository
    {
        public CertificateRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
