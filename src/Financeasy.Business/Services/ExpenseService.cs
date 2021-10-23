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
    public class ExpenseService : Service, IExpenseService
    {
        private readonly IExpenseRepository _expenseService;

        public ExpenseService(
            INotifier notifier,
            IUnitOfWork unitOfWork,
            IExpenseRepository expenseService) : base(notifier, unitOfWork)
        {
            _expenseService = expenseService;
        }

        public Guid Add(ExpenseAddModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Expense> GetAll()
        {
            throw new NotImplementedException();
        }

        public Expense GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ExpenseUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}