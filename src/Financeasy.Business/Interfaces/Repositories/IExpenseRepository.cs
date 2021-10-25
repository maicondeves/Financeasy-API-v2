using Financeasy.Business.Entities;
using Financeasy.Core;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        ICollection<Expense> GetAll();
    }
}