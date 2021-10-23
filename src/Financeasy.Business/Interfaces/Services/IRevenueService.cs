using Financeasy.Business.Entities;
using Financeasy.Business.Models;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Services
{
    public interface IRevenueService
    {
        Guid Add(RevenueAddModel model);

        void Update(RevenueUpdateModel model);

        void Delete(Guid id);

        Revenue GetById(Guid id);

        ICollection<Revenue> GetAll();
    }
}