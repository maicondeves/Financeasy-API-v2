using Financeasy.Business.Entities;
using Financeasy.Core;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        ICollection<Project> GetAll();
    }
}