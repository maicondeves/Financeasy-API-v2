using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Financeasy.Api.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(INotifier notifier, ICategoryService categoryService) : base(notifier)
        {
            _categoryService = categoryService;
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] CategoryAddModel model)
        {
            try
            {
                return Response(_categoryService.Add(model));
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("")]
        [HttpPut]
        public IActionResult Put([FromBody] CategoryUpdateModel model)
        {
            try
            {
                _categoryService.Update(model);
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
                _categoryService.Delete(id);
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
                return Response(_categoryService.GetById(id));
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
                return Response(_categoryService.GetAll());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }
    }
}