using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Business.Interfaces.Repositories.Common;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Business.Services.Common;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Services
{
    public class CategoryService : Service, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(
            INotifier notifier,
            IUnitOfWork unitOfWork,
            ICategoryRepository categoryRepository) : base(notifier, unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }

        public Guid Add(CategoryAddModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}