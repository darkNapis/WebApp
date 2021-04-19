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
        private readonly IEmailService _emailService;
        private readonly IRoleService _roleService;
        private readonly IUserInRoleService _userInRoleService;
        public UserController(IUserService user, IEmailService email, IRoleService role, IUserInRoleService userInRole)
        {
            _userService = user;
            _emailService = email;
            _roleService = role;
            _userInRoleService = userInRole;
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
        public ActionResult Create(User user, string email1)                                                                                          
        {
            var userExist = _userService.CheckUserName(user);
            var emailExist = _userService.CheckEmail(email1);

            if (emailExist)
                return StatusCode(StatusCodes.Status409Conflict, "Email exist.");
            if (userExist)
                return StatusCode(StatusCodes.Status409Conflict, "UserName exist.");
            var userNew = new User()
            {
                Name = user.Name,
                SurName = user.SurName,
                UserName = user.UserName,
            };
            var newUser = _userService.Create(userNew);

            var email = new Email()
            {
                UserId = newUser.Id,
                Emails = email1,
                Users = newUser

            };

            var newEmail = _emailService.Create(email);
            newUser.Emails.Add(email);

            return StatusCode(StatusCodes.Status201Created, newUser);
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
