using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("controller")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService user)
        {
            _userService = user;
        }

        [HttpGet]
        public List<Users> Get()
        {
            return _userService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Users Details(int id)
        {
            return _userService.Get(id);
        }

        [HttpGet]
        [Route("{id}")]
        public Users GetAll(int id)
        {
            return _userService.Get(id);
        }

        [HttpGet]
        [Route("{id}")]
        public Users GetAllPaginated(int id)
        {
            return _userService.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public Users Create(Users model)
        {
            return _userService.Add(model);
        }

        [HttpPut]
        [Route("update")]
        public Users Update(Users user)
        {
            return _userService.Update(user);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _userService.Delete(id);
        }
    }
}
