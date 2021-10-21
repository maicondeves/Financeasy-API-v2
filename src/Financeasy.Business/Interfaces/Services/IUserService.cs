using Financeasy.Business.Models;
using System;

namespace Financeasy.Business.Interfaces.Services
{
    public interface IUserService
    {
        void GetById(Guid id);

        void GetAll();

        void GetAllActive();

        void GetAllInactive();

        void GetAllBlocked();

        void Add(UserPostModel model);

        void Update(UserPutModel model);

        void Delete(Guid id);
    }
}