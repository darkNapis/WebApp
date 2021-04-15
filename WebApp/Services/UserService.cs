using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Errors;
using WebApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class UserService : IUserService
    {
        private readonly IDataContext db;
        public UserService(IDataContext db)
        {
            this.db = db;
        }
        public User Details(int id)
        {
            var details = db.Users.FirstOrDefault(c => c.Id == id);
            return details;
        }
        public int CheckUser(int id)
        {
            var user = db.Users.FirstOrDefault(c => c.Id == id);
            if (user == null)
            return 0;
            return 1;
        }
        public List<User> GetAll()
        {
            return db.Users.ToList();
        }
        public async Task<List<User>> GetAllPaginated(int offSet, int numberPerPage)
        {
            List<User> paginatedUsers = await db.Users.OrderBy(x => x.Id)
                                   .Skip(offSet * numberPerPage)
                                   .Take(numberPerPage).ToListAsync();
            //paginatedUsers.OrderBy(x => x.Id)
            //                       .Skip(offSet * numberPerPage)
            //                       .Take(numberPerPage).ToList();
            if (paginatedUsers.Count == 0)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest,
                    new { users = "Zero users found for this page" });
            }
            return paginatedUsers;
        }
        public User Create(User user)
        {
            var createdUser = db.Users.Add(user);
            db.SaveChanges();
            return createdUser.Entity;
        }
        public User Update(User users)
        {
            var updatedUser = db.Users.Update(users);
            db.SaveChanges();
            return updatedUser.Entity;
        }
        public bool Delete(int id)
        {
            var us = db.Users.FirstOrDefault(c => c.Id == id);
            db.Users.Remove(us);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }
        public User DeleteBatch(User users)
        {
            var removedUser = db.Users.Remove(users);
            db.SaveChanges();
            return removedUser.Entity;
        }
        public bool CheckUserName(User userNameExist)
        {
            var user = db.Users.Any(c => c.UserName.Equals(userNameExist.UserName));
            return user;      
        }
        public bool CheckEmail(Email emailExist)
        {
            var email = db.Emails.Any(c => c.Emails.Equals(emailExist.Emails));  
            return email;
        }
    }
}
