using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Services
{
    public class UserService : IUserService
    {
        private readonly IDataContext db;
        public UserService(IDataContext db)
        {
            this.db = db;
        }
        public Users Add(Users users)
        {
            var us = db.Users.Add(users);
            db.SaveChanges();
            return us.Entity;
        }

        public bool Delete(int id)
        {
            var us = db.Users.FirstOrDefault(c => c.Id == id);
            db.Users.Remove(us);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<Users> Get()
        {
            return db.Users.ToList();
        }

        public Users Get(int id)
        {
            return db.Users.FirstOrDefault(c => c.Id == id);
        }

        public Users Update(Users users)
        {
            var updatedUser = db.Users.Update(users);
            db.SaveChanges();
            return updatedUser.Entity;
        }
    }
}
