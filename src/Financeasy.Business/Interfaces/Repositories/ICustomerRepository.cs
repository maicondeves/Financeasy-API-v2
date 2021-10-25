using Financeasy.Business.Entities;
using Financeasy.Core;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        ICollection<Customer> GetAll();
    }
}