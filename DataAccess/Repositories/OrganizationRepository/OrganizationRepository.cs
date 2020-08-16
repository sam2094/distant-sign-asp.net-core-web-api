using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DataAccess.Repositories.OrganizationRepository
{
    public class OrganizationRepository : GenericRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
