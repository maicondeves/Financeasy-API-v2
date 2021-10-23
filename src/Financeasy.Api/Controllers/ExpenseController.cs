using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Financeasy.Api.Controllers
{
    [Route("expenses")]
    [ApiController]
    public class ExpenseController : BaseController
    {
        private readonly IExpenseService _expenseService;

        public ExpenseController(INotifier notifier, IExpenseService expenseService) : base(notifier)
        {
            _expenseService = expenseService;
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] ExpenseAddModel model)
        {
            try
            {
                return Response(_expenseService.Add(model));
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("")]
        [HttpPut]
        public IActionResult Put([FromBody] ExpenseUpdateModel model)
        {
            try
            {
                _expenseService.Update(model);
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
                _expenseService.Delete(id);
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
                return Response(_expenseService.GetById(id));
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
                return Response(_expenseService.GetAll());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }
    }
}