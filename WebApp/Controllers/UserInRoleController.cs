using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities;
using WebApp.Services;
using WebApp.Services.Interfaces;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserInRoleController : ControllerBase
    {
        private readonly IUsersInRolesService _userInRolesService;
        public UserInRoleController(IUsersInRolesService usersInRoles)
        {
            _userInRolesService = usersInRoles;
        }

        [HttpGet]
        public List<UserInRole> Get()
        {
            return _userInRolesService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public UserInRole Get(int id)
        {
            return _userInRolesService.Get(id);
        }

        [HttpPost]
        [Route("add")]
        public UserInRole Add(UserInRole model)
        {
            return _userInRolesService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public UserInRole Update(UserInRole userInRoles)
        {
            return _userInRolesService.Update(userInRoles);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _userInRolesService.Delete(id);
        }
    }
}
