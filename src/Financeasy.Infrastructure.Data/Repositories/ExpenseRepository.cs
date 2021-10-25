using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Financeasy.Infrastructure.Data.Repositories
{
    public sealed class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(FinanceasyContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Expense> GetAll() =>
            _dbSet.AsNoTracking().ToList();
    }
}