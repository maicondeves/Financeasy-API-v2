using System;

namespace Financeasy.Business.Interfaces.Repositories.Common
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}