using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Core;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Financeasy.Api.Controllers
{
    [Route("revenues")]
    [ApiController]
    public class RevenueController : BaseController
    {
        private readonly IRevenueService _revenueService;

        public RevenueController(INotifier notifier, IRevenueService revenueService) : base(notifier)
        {
            _revenueService = revenueService;
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] RevenueAddModel model)
        {
            try
            {
                return Response(_revenueService.Add(model));
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("")]
        [HttpPut]
        public IActionResult Put([FromBody] RevenueUpdateModel model)
        {
            try
            {
                _revenueService.Update(model);
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
                _revenueService.Delete(id);
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
                return Response(_revenueService.GetById(id));
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
                return Response(_revenueService.GetAll());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }
    }
}