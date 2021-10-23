using Financeasy.Business.Entities;
using Financeasy.Business.Models;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Services
{
    public interface IExpenseService
    {
        Guid Add(ExpenseAddModel model);

        void Update(ExpenseUpdateModel model);

        void Delete(Guid id);

        Expense GetById(Guid id);

        ICollection<Expense> GetAll();
    }
}