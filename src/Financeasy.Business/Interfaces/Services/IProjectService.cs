using Financeasy.Business.Entities;
using Financeasy.Business.Models;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Services
{
    public interface IProjectService
    {
        Guid Add(ProjectAddModel model);

        void Update(ProjectUpdateModel model);

        void Delete(Guid id);

        Project GetById(Guid id);

        ICollection<Project> GetAll();
    }
}