using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DataAccess.Repositories.BranchRepository
{
    public class BranchRepository : GenericRepository<Branch>, IBranchRepository
    {
        public BranchRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
