using Financeasy.Business.Entities;
using Financeasy.Business.Models;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Services
{
    public interface ICustomerService
    {
        Guid Add(CustomerAddModel model);

        void Update(CustomerUpdateModel model);

        void Delete(Guid id);

        Customer GetById(Guid id);

        ICollection<Customer> GetAll();
    }
}