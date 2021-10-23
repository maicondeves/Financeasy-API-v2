using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        ICollection<Customer> GetAll();
    }
}