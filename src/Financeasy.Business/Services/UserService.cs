using AutoMapper;
using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Business.Interfaces.Repositories.Common;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Business.Services.Common;
using Financeasy.Business.Validations;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Services
{
    public class UserService : Service, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(
            INotifier notifier,
            IUnitOfWork unitOfWork,
            IUserRepository userRepository) : base(notifier, unitOfWork)
        {
            _userRepository = userRepository;
        }

        public void Add(UserPostModel model)
        {
            // Business rules and validations based on data from database.
            if (_userRepository.AlreadyExists(model.Email))
            {
                Notify("Already exists a user with this email.");
                return;
            }

            var user = new User(model.Name, model.Email, model.Password);

            // After all the business rules validations, execute validation based on entity attributes, validate if entity is valid to persist on database.
            if (!EntityIsValid(new UserValidation(), user))
                return;

            _userRepository.Add(user);

            Commit();
        }

        public void Update(UserPutModel model)
        {
            // Business rules and validations based on data from database.
            var user = _userRepository.GetById(model.Id);

            if (user is null)
            {
                Notify("User not found");
                return;
            }

            user.Update(model.Name, model.Email, model.Password);

            // After all the business rules validations, execute validation based on entity attributes, validate if entity is valid to persist on database.
            if (!EntityIsValid(new UserValidation(), user))
                return;

            _userRepository.Update(user);

            Commit();
        }

        public void Delete(Guid id)
        {
            // Business rules and validations based on data from database.
            var user = _userRepository.GetById(id);

            if (user is null)
            {
                Notify("User not found");
                return;
            }

            _userRepository.Remove(user);

            Commit();
        }

        public User GetById(Guid id)
            => _userRepository.GetById(id);

        public ICollection<User> GetAll()
            => _userRepository.GetAll();

        public ICollection<User> GetAllActive()
            => _userRepository.GetAllActive();

        public ICollection<User> GetAllInactive()
            => _userRepository.GetAllInactive();

        public ICollection<User> GetAllBlocked()
            => _userRepository.GetAllBlocked();
    }
}