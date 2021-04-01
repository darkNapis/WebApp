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
    [Route("controller")]
    public class UsersInRolesController : ControllerBase
    {
        private readonly IUsersInRolesService _userInRolesService;
        public UsersInRolesController(IUsersInRolesService usersInRoles)
        {
            _userInRolesService = usersInRoles;
        }

        [HttpGet]
        public List<UsersInRoles> Get()
        {
            return _userInRolesService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public UsersInRoles Get(int id)
        {
            return _userInRolesService.Get(id);
        }


        [HttpPost]
        [Route("create")]
        public UsersInRoles Create(UsersInRoles model)
        {
            return _userInRolesService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public UsersInRoles Update(UsersInRoles club)
        {
            return _userInRolesService.Update(club);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _userInRolesService.Delete(id);
        }
    }
}
