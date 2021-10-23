using Financeasy.Business.Entities;
using Financeasy.Business.Models;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Services
{
    public interface IUserService
    {
        Guid Add(UserAddModel model);

        void Update(UserUpdateModel model);

        void Delete(Guid id);

        User GetById(Guid id);

        ICollection<User> GetAll();

        ICollection<User> GetAllActive();

        ICollection<User> GetAllInactive();

        ICollection<User> GetAllBlocked();
    }
}