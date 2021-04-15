using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService role)
        {
            _roleService = role;
        }

        [HttpGet]
        public List<Role> Get()
        {
            return _roleService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Role Get(int id)
        {
            return _roleService.Get(id);
        }

        [HttpPost]
        [Route("addUserRoles")]
        public Role AddUserRoles(Role userRole, int id)
        {
            return _roleService.AddUserRoles(userRole, id);
        }

        [HttpPatch]
        [Route("update")]
        public Role Update(Role role)
        {
            return _roleService.Update(role);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool RemoveUserRole(Role userRole, int id)
        { 
            return _roleService.RemoveUserRole(userRole, id);
        }
    }
}
