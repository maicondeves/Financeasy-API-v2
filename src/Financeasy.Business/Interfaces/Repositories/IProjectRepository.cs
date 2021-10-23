using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        ICollection<Project> GetAll();
    }
}