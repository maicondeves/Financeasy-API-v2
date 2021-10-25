using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Core;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Financeasy.Api.Controllers
{
    [Route("projects")]
    [ApiController]
    public class ProjectController : BaseController
    {
        private readonly IProjectService _projectService;

        public ProjectController(INotifier notifier, IProjectService projectService) : base(notifier)
        {
            _projectService = projectService;
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] ProjectAddModel model)
        {
            try
            {
                return Response(_projectService.Add(model));
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("")]
        [HttpPut]
        public IActionResult Put([FromBody] ProjectUpdateModel model)
        {
            try
            {
                _projectService.Update(model);
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete([FromRoute] Guid id)
        {
            try
            {
                _projectService.Delete(id);
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById([FromRoute] Guid id)
        {
            try
            {
                return Response(_projectService.GetById(id));
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Response(_projectService.GetAll());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }
    }
}