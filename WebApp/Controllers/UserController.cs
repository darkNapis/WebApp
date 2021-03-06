using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities;
using WebApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using Microsoft.AspNetCore.Http;

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
        public User Details(int id)
        {
            return _userService.Details(id);
            //var user = _userService.Details(id);
            //if (_userService.CheckUser(id) == 0)
            //return NotFound("User Not Found");
            //return Ok(user);
        }
        [HttpGet]
        public List<User> GetAll()
        {
            return _userService.GetAll();
        }
        [HttpGet]
        [Route("paginated")]
        public async Task<List<User>> GetAllPaginated(int offSet, int numberPerPage)
        {
            return await _userService.GetAllPaginated(offSet, numberPerPage);
            //if (numberPerPages == null)
            //return StatusCode(StatusCodes.Status409Conflict, "Offset out of bounds");
            //return StatusCode(StatusCodes.Status200OK, numberPerPages);
        }
        [HttpPost]
        [Route("create")]
        public User Create(User user)
        {
            //var userExist = _userService.CheckUserName(user);
            //if (userExist)
            //return StatusCode(StatusCodes.Status409Conflict, "UserName exist.");
            //var newUser = _userService.Create(user);
            //return StatusCode(StatusCodes.Status201Created, newUser);
            return _userService.Create(user);
        }
        [HttpPut]
        [Route("update")]
        public ActionResult Update(User user)
        {
            var newUser = _userService.Update(user);
            return StatusCode(StatusCodes.Status200OK, newUser);
        }
        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _userService.Delete(id);
        }
        [HttpDelete]
        public User DeleteBatch(User users)
        {
            return _userService.DeleteBatch(users);
        }
    }
}
