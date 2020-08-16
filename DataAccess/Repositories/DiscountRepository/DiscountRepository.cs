using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DataAccess.Repositories.DiscountRepository
{
    public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
