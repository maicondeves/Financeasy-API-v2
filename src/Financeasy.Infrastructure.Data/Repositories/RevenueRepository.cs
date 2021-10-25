using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Financeasy.Infrastructure.Data.Repositories
{
    public sealed class RevenueRepository : Repository<Revenue>, IRevenueRepository
    {
        public RevenueRepository(FinanceasyContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Revenue> GetAll() =>
            _dbSet.AsNoTracking().ToList();
    }
}