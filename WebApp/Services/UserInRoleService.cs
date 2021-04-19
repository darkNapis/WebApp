using System.Collections.Generic;
using System.Linq;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Services
{

    public class UserInRoleService : IUserInRoleService
    {
        private readonly IDataContext db;
        public UserInRoleService(IDataContext db)
        {
            this.db = db;
        }
        public UserInRole Add(UserInRole usersInRoles)
        {
            var us = db.UsersInRoles.Add(usersInRoles);
            db.SaveChanges();
            return us.Entity;
        }

        public bool Delete(int id)
        {
            var us = db.UsersInRoles.FirstOrDefault(c => c.Id == id);
            db.UsersInRoles.Remove(us);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<UserInRole> Get()
        {
            return db.UsersInRoles.ToList();
        }

        public UserInRole Get(int id)
        {
            return db.UsersInRoles.FirstOrDefault(c => c.Id == id);
        }

        public UserInRole Update(UserInRole usersInRoles)
        {
            var updatedUsersInRoles = db.UsersInRoles.Update(usersInRoles);
            db.SaveChanges();
            return updatedUsersInRoles.Entity;
        }
    }
}
