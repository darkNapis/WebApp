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
        public List<Roles> Get()
        {
            return _roleService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Roles Get(int id)
        {
            return _roleService.Get(id);
        }

        [HttpPost]
        [Route("add")]
        public Roles AddUserRoles(Roles userRole, int id)
        {
            return _roleService.AddUserRoles(userRole, id);
        }

        [HttpPatch]
        [Route("update")]
        public Roles Update(Roles role)
        {
            return _roleService.Update(role);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool RemoveUserRole(Roles userRole, int id)
        {
            return _roleService.RemoveUserRole(userRole, id);
        }
    }
}
