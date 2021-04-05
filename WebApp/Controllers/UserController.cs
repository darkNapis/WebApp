using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities;
using WebApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService user)
        {
            _userService = user;
        }

        [HttpGet]
        [Route("{id}")]
        public Users Details(int id)
        {
            return _userService.Details(id);
        }

        [HttpGet]
        public List<Users> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet]
        [Route("paginated")]
        public List<Users> GetAllPaginated(int numberOfpage, int offSet)
        {
            return _userService.GetAllPaginated(numberOfpage, offSet);
        }

        [HttpPost]
        [Route("create")]
        public Users Add(Users user)
        {
            return _userService.Add(user);
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
        [HttpDelete]
        public bool DeleteBatch(int id)
        {
            return _userService.DeleteBatch(id);
        }
    }
}
