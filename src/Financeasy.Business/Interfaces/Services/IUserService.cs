using Financeasy.Business.Entities;
using Financeasy.Business.Models;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Services
{
    public interface IUserService
    {
        User GetById(Guid id);

        ICollection<User> GetAll();

        ICollection<User> GetAllActive();

        ICollection<User> GetAllInactive();

        ICollection<User> GetAllBlocked();

        void Add(UserPostModel model);
        void Update(UserPutModel model);
        void Delete(Guid id);
    }
}