using Financeasy.Business.Entities;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Models;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Services
{
    public interface ICategoryService
    {
        Guid Add(CategoryAddModel model);

        void Update(CategoryUpdateModel model);

        void Delete(Guid id);

        Category GetById(Guid id);

        ICollection<Category> GetAll();

        ICollection<Category> GetAllByType(CategoryType type);
    }
}