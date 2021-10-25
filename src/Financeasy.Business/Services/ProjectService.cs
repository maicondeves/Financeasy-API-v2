using Financeasy.Business.Entities;
using Financeasy.Business.Interfaces.Repositories;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Core;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Services
{
    public sealed class ProjectService : Service, IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(
            INotifier notifier,
            IUnitOfWork unitOfWork,
            IProjectRepository projectRepository) : base(notifier, unitOfWork)
        {
            _projectRepository = projectRepository;
        }

        public Guid Add(ProjectAddModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public Project GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProjectUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }
}