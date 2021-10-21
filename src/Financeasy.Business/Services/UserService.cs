using Financeasy.Business.Core;
using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Business.Interfaces.Repositories.Common;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Business.Services.Common;
using System;

namespace Financeasy.Business.Services
{
    public class UserService : Service, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(
            INotifier notifier,
            IMediator mediator,
            IUnitOfWork unitOfWork,
            IUserRepository userRepository) : base(notifier, mediator, unitOfWork)
        {
            _userRepository = userRepository;
        }

        private void CheckIfEmailIsUsed(string email)
        {
            // Business rules and validations based in data that are stored on database.
            if (_userRepository.EmailAlreadyUsed(email))
                throw new BusinessException("Already exists a user with this email.");
        }

        private User GetByIdIfExists(Guid id)
        {
            // Business rules and validations based in data that are stored on database.
            var user = _userRepository.GetById(id);

            if (user is null)
                throw new BusinessException("User not found");

            return user;
        }

        public void Add(UserPostModel model)
        {
            // Check if the email received is already in use is called, if already in use, a BusinessException will be thrown.
            CheckIfEmailIsUsed(model.Email);

            // Create a instance of entity User.
            var user = new User(model.Name, model.Email, model.Password);

            // Persist entity on database using EntityFrameworkCore.
            _userRepository.Add(user);

            // Confirm the changes on database. The famous Commit.
            Commit();

            // Return the Id of the User recently created.
            Return(user.Id);
        }

        public void Update(UserPutModel model)
        {
            // Get the User entity by Id, if the user doesn't exists, a BusinessException will be thrown.
            var user = GetByIdIfExists(model.Id);

            // If the user email is different from email received, a validation to check if the email received is already in use is called, if already in use, a BusinessException will be thrown.
            if (!user.Email.Equals(model.Email))
                CheckIfEmailIsUsed(model.Email);

            user.ChangeEmail(model.Email);
            user.ChangePassword(model.Password);

            _userRepository.Update(user);

            Commit();
        }

        public void Delete(Guid id)
        {
            // Get the User entity by Id, if the user doesn't exists, a BusinessException will be thrown.
            var user = GetByIdIfExists(id);

            // Delete the user from database.
            _userRepository.Remove(user);

            // Confirm the changes on database. The famous Commit.
            Commit();
        }

        public void GetById(Guid id)
            => Return(_userRepository.GetById(id));

        public void GetAll()
            => Return(_userRepository.GetAll());

        public void GetAllActive()
            => Return(_userRepository.GetAllActive());

        public void GetAllInactive()
            => Return(_userRepository.GetAllInactive());

        public void GetAllBlocked()
            => Return(_userRepository.GetAllBlocked());
    }
}