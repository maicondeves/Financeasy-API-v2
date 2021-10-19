using Financeasy.Business.Interfaces.Repositories.Common;
using Financeasy.Infrastructure.Data.Contexts;
using System;

namespace Financeasy.Infrastructure.Data.Common
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