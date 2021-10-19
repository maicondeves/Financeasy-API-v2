using Financeasy.Business.Core;
using Financeasy.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;

namespace Financeasy.Infrastructure.Data.Common
{
    public abstract class Repository<TEntity> where TEntity : Entity, new()
    {
        private readonly FinanceasyContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(FinanceasyContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            entity.SetLastUpdate();
            _dbSet.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}