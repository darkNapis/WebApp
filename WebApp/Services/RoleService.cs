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
        public Role AddUserRoles(Role roles, int id)
        {
            var ro = db.Roles.Add(roles);
            db.SaveChanges();
            return ro.Entity;
        }

        public bool RemoveUserRole(Role UserRole, int id)
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
    }
}
