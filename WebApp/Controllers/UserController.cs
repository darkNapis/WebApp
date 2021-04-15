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
        public IActionResult Details(int id)
        {
            var user = _userService.Details(id);
            if (_userService.CheckUser(id) == 0)
            return NotFound("User Not Found");
            return Ok(user);
        }
        [HttpGet]
        public List<Users> GetAll()
        {
            return _userService.GetAll();
        }
        [HttpGet]
        [Route("paginated")]
        public ActionResult GetAllPaginated(int offSet, int numberPerPage)
        {
            var numberPerPages = _userService.GetAllPaginated(offSet, numberPerPage).OrderBy(x => x.Id)
                                   .Skip(offSet * numberPerPage)
                                   .Take(numberPerPage).ToList();
            if (numberPerPages == null)
            {
                return StatusCode(StatusCodes.Status409Conflict, "Offset out of bounds");
            }
            return StatusCode(StatusCodes.Status200OK, numberPerPages);
        }
        [HttpPost]
        [Route("create")]
        public ActionResult Create(Users user)                                                                                          
        {
            var userExist = _userService.CheckUserName(user);
            if (userExist)
            return StatusCode(StatusCodes.Status409Conflict, "UserName exist.");
            var newUser = _userService.Create(user);
            return StatusCode(StatusCodes.Status201Created, newUser);
        }
        [HttpPut]
        [Route("update")]
        public ActionResult Update(Users user)
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
        public Users DeleteBatch(Users users)
        {
            return _userService.DeleteBatch(users);
        }
    }
}
