using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Core;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Services
{
    public sealed class CustomerService : Service, ICustomerService
    {
        private readonly ICustomerRepository _customerService;

        public CustomerService(
            INotifier notifier,
            IUnitOfWork unitOfWork,
            ICustomerRepository customerService) : base(notifier, unitOfWork)
        {
            _customerService = customerService;
        }

        public Guid Add(CustomerAddModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}