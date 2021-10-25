using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Financeasy.Infrastructure.Data.Repositories
{
    public sealed class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(FinanceasyContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Project> GetAll() =>
            _dbSet.AsNoTracking().ToList();
    }
}