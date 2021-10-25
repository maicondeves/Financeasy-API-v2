using Financeasy.Business.Entities;
using Financeasy.Business.Enumerators;
using Financeasy.Core;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        ICollection<Category> GetAll();

        ICollection<Category> GetAllByType(CategoryType type);
    }
}