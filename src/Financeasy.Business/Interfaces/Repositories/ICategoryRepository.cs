using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        ICollection<Category> GetAll();
    }
}