using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        ICollection<User> GetAll();

        ICollection<User> GetAllActive();

        ICollection<User> GetAllInactive();

        ICollection<User> GetAllBlocked();

        bool EmailAlreadyUsed(string email);
    }
}