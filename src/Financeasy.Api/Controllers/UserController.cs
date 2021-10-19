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

        public UserController(INotifier notifier, IUserService userService) : base(notifier)
        {
            _userService = userService;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById([FromRoute] Guid id)
        {
            try
            {
                return DefaultResponse(_userService.GetById(id));
            }
            catch (Exception e)
            {
                return DefaultResponse(e);
            }
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return DefaultResponse(_userService.GetAll());
            }
            catch (Exception e)
            {
                return DefaultResponse(e);
            }
        }

        [Route("active")]
        [HttpGet]
        public IActionResult GetAllActive()
        {
            try
            {
                return DefaultResponse(_userService.GetAllActive());
            }
            catch (Exception e)
            {
                return DefaultResponse(e);
            }
        }

        [Route("blocked")]
        [HttpGet]
        public IActionResult GetAllBlocked()
        {
            try
            {
                return DefaultResponse(_userService.GetAllBlocked());
            }
            catch (Exception e)
            {
                return DefaultResponse(e);
            }
        }

        [Route("inactive")]
        [HttpGet]
        public IActionResult GetAllInactive()
        {
            try
            {
                return DefaultResponse(_userService.GetAllInactive());
            }
            catch (Exception e)
            {
                return DefaultResponse(e);
            }
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

            return DefaultResponse();
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

            return DefaultResponse();
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

            return DefaultResponse();
        }
    }
}