using Financeasy.Business.Entities;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Infrastructure.Data.Common;
using Financeasy.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Financeasy.Infrastructure.Data.Repositories
{
    public sealed class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(FinanceasyContext dbContext) : base(dbContext)
        {
        }

        public override Category GetById(Guid id) =>
            _dbSet.Where(x => x.Id == id)
                .Include(x => x.User)
                .FirstOrDefault();

        public ICollection<Category> GetAll() =>
            _dbSet.AsNoTracking()
                .Include(x => x.User)
                .ToList();

        public ICollection<Category> GetAllByType(CategoryType type)
        {
            return _dbSet.Where(c => c.Type == type)
                .AsNoTracking()
                .Include(x => x.User)
                .ToList();
        }
    }
}