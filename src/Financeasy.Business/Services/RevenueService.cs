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
    public sealed class RevenueService : Service, IRevenueService
    {
        private readonly IRevenueRepository _userRepository;

        public RevenueService(
            INotifier notifier,
            IUnitOfWork unitOfWork,
            IRevenueRepository userRepository) : base(notifier, unitOfWork)
        {
            _userRepository = userRepository;
        }

        public Guid Add(RevenueAddModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(RevenueUpdateModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Revenue> GetAll()
        {
            throw new NotImplementedException();
        }

        public Revenue GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}