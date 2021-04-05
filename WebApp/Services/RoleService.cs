using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public Roles AddUserRoles(Roles roles, int id)
        {
            var ro = db.Roles.Add(roles);
            db.SaveChanges();
            return ro.Entity;
        }

        public bool RemoveUserRole(Roles UserRole, int id)
        {
            var ro = db.Roles.FirstOrDefault(c => c.Id == id);
            db.Roles.Remove(ro);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<Roles> Get()
        {
            return db.Roles.ToList();
        }

        public Roles Get(int id)
        {
            return db.Roles.FirstOrDefault(c => c.Id == id);
        }

        public Roles Update(Roles roles)
        {
            var updatedRole = db.Roles.Update(roles);
            db.SaveChanges();
            return updatedRole.Entity;
        }
    }
}
