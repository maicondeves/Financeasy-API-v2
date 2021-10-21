using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Financeasy.Api.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(INotifier notifier, IMediator mediator, IUserService userService) : base(notifier, mediator)
        {
            _userService = userService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                _userService.GetAll();
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
                _userService.GetById(id);
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("active")]
        [HttpGet]
        public IActionResult GetAllActive()
        {
            try
            {
                _userService.GetAllActive();
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("blocked")]
        [HttpGet]
        public IActionResult GetAllBlocked()
        {
            try
            {
                _userService.GetAllBlocked();
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("inactive")]
        [HttpGet]
        public IActionResult GetAllInactive()
        {
            try
            {
                _userService.GetAllInactive();
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] UserPostModel model)
        {
            try
            {
                _userService.Add(model);
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult Put([FromBody] UserPutModel model, [FromRoute] Guid id)
        {
            try
            {
                if (id != model.Id)
                {
                    Notify("User Id is invalid");
                }
                else
                {
                    _userService.Update(model);
                }
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
                _userService.Delete(id);
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }
    }
}