using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Infrastructure.Data.Common;
using Financeasy.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Financeasy.Infrastructure.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(FinanceasyContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Category> GetAll() =>
            _dbSet.AsNoTracking().ToList();
    }
}