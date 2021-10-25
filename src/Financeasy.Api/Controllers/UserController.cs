using Financeasy.Business.Interfaces.Services;
using Financeasy.Business.Models;
using Financeasy.Core;
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
                return Response(_userService.GetById(id));
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
                return Response(_userService.GetAll());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }

        [Route("active")]
        [HttpGet]
        public IActionResult GetAllActive()
        {
            try
            {
                return Response(_userService.GetAllActive());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }

        [Route("blocked")]
        [HttpGet]
        public IActionResult GetAllBlocked()
        {
            try
            {
                return Response(_userService.GetAllBlocked());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }

        [Route("inactive")]
        [HttpGet]
        public IActionResult GetAllInactive()
        {
            try
            {
                return Response(_userService.GetAllInactive());
            }
            catch (Exception e)
            {
                return Response(e);
            }
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] UserAddModel model)
        {
            try
            {
                return Response(_userService.Add(model));
            }
            catch (Exception e)
            {
                Notify(e);
            }

            return Response();
        }

        [Route("")]
        [HttpPut]
        public IActionResult Put([FromBody] UserUpdateModel model)
        {
            try
            {
                _userService.Update(model);
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