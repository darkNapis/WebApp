using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Services
{

    public class UsersinRolesService : IUsersInRolesService
    {
        private readonly IDataContext db;
        public UsersinRolesService(IDataContext db)
        {
            this.db = db;
        }
        public UsersInRoles Add(UsersInRoles usersInRoles)
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

        public List<UsersInRoles> Get()
        {
            return db.UsersInRoles.ToList();
        }

        public UsersInRoles Get(int id)
        {
            return db.UsersInRoles.FirstOrDefault(c => c.Id == id);
        }

        public UsersInRoles Update(UsersInRoles usersInRoles)
        {
            var updatedUsersInRoles = db.UsersInRoles.Update(usersInRoles);
            db.SaveChanges();
            return updatedUsersInRoles.Entity;
        }
    }
}
