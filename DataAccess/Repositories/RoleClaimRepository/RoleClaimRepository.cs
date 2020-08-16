using Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.RoleClaimRepository
{
   public class RoleClaimRepository : GenericRepository<RoleClaim>, IRoleClaimRepository
    {
        public RoleClaimRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
