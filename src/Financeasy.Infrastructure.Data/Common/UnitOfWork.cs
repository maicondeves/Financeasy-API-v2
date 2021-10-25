using Financeasy.Core;
using Financeasy.Infrastructure.Data.Contexts;
using System;

namespace Financeasy.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FinanceasyContext _dbContext;

        public UnitOfWork(FinanceasyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Commit() =>
            _dbContext.SaveChanges();

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}