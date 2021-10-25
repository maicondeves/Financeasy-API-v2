using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Core;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Financeasy.Api.Controllers
{
    [Route("customers")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(INotifier notifier, ICustomerService customerService) : base(notifier)
        {
            _customerService = customerService;
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] CustomerAddModel model)
        {
            try
            {
                return Response(_customerService.Add(model));
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("")]
        [HttpPut]
        public IActionResult Put([FromBody] CustomerUpdateModel model)
        {
            try
            {
                _customerService.Update(model);
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
                _customerService.Delete(id);
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
                return Response(_customerService.GetById(id));
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
                return Response(_customerService.GetAll());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }
    }
}