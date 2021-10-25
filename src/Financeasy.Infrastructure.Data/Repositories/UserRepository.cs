using Financeasy.Business.Entities;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Financeasy.Infrastructure.Data.Repositories
{
    public sealed class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(FinanceasyContext dbContext) : base(dbContext)
        {
        }

        public ICollection<User> GetAll() =>
            _dbSet.AsNoTracking().ToList();

        public ICollection<User> GetAllActive() =>
            _dbSet
                .Where(x => x.Status == UserStatus.Active)
                .AsNoTracking()
                .ToList();

        public ICollection<User> GetAllInactive() =>
            _dbSet
                .Where(x => x.Status == UserStatus.Inactive)
                .AsNoTracking()
                .ToList();

        public ICollection<User> GetAllBlocked() =>
            _dbSet
                .Where(x => x.Status == UserStatus.Blocked)
                .AsNoTracking()
                .ToList();

        public bool EmailAlreadyUsed(string email) =>
            _dbSet.Any(x => x.Email == email);
    }
}