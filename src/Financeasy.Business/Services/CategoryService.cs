using Financeasy.Business.Entities;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Core;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Services
{
    public sealed class CategoryService : Service, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(
            INotifier notifier,
            IUnitOfWork unitOfWork,
            ICategoryRepository categoryRepository) : base(notifier, unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }

        private Category GetByIdIfExists(Guid id)
        {
            // Business rules and validations based in data that are stored on database.
            var category = _categoryRepository.GetById(id);

            if (category is null)
                throw new BusinessException("Category not found");

            return category;
        }

        private static void ValidateType(CategoryType type)
        {
            if (!Enum.IsDefined(typeof(CategoryType), type))
                throw new BusinessException("Category type is invalid");
        }

        public Guid Add(CategoryAddModel model)
        {
            // Validate if value on Enum is valid
            ValidateType(model.Type);

            var category = new Category(model.Name, model.Type, model.UserId);

            _categoryRepository.Add(category);

            // Confirm the changes on database.
            Commit();

            // Return the Id recently created.
            return category.Id;
        }

        public void Update(CategoryUpdateModel model)
        {
            // Validate if value on Enum is valid
            ValidateType(model.Type);

            // Get the entity by Id, if the entity doesn't exists, a BusinessException will be thrown.
            var category = GetByIdIfExists(model.Id);

            category.ChangeName(model.Name);
            category.ChangeType(model.Type);

            // Persist entity on database using EntityFrameworkCore.
            _categoryRepository.Update(category);

            // Confirm the changes on database.
            Commit();
        }

        public void Delete(Guid id)
        {
            // Get the entity by Id, if the entity doesn't exists, a BusinessException will be thrown.
            var category = GetByIdIfExists(id);

            // Delete the entity from database.
            _categoryRepository.Remove(category);

            // Confirm the changes on database.
            Commit();
        }

        public Category GetById(Guid id)
            => _categoryRepository.GetById(id);

        public ICollection<Category> GetAll()
            => _categoryRepository.GetAll();

        public ICollection<Category> GetAllByType(CategoryType type)
        {
            // Validate if value on Enum is valid
            ValidateType(type);

            return _categoryRepository.GetAllByType(type);
        }
    }
}