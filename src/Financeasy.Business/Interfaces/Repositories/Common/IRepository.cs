using Financeasy.Business.Core;
using System;

namespace Financeasy.Business.Interfaces.Repositories.Common
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        TEntity GetById(Guid id);
    }
}