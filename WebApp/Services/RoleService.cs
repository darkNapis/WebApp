using System.Collections.Generic;
using System.Linq;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Services
{
    public class RoleService : IRoleService
    {
        private readonly IDataContext db;
        public RoleService(IDataContext db)
        {
            this.db = db;
        }
        public Role AddUserRoles(int id, Role role)
        {
            //var roleExist = CheckUserRole(id, role);
            //if (roleExist)
            //{
            //    throw new RestException(System.Net.HttpStatusCode.BadRequest,
            //        new { users = "User does not exist" });
            //}
            //Role createRole = db.Roles.AddRange(intid, role);
            //db.SaveChanges();
            //return createRole;
            var createRole = db.Roles.Add(role);
            db.SaveChanges();
            return createRole.Entity;
        }

        public bool RemoveUserRole(int id, Role role)
        {
            var ro = db.Roles.FirstOrDefault(c => c.Id == id);
            db.Roles.Remove(ro);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<Role> Get()
        {
            return db.Roles.ToList();
        }

        public Role Get(int id)
        {
            return db.Roles.FirstOrDefault(c => c.Id == id);
        }

        public Role Update(Role roles)
        {
            var updatedRole = db.Roles.Update(roles);
            db.SaveChanges();
            return updatedRole.Entity;
        }

        public bool CheckUserRole(int id, Role role)
        {
            var userRole = db.Roles.Any(c => c.Id == id & c.RoleName == role.ToString());
            return userRole;
        }
    }
}
