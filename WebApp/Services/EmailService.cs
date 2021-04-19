using System.Collections.Generic;
using System.Linq;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Services.Interfaces;

namespace WebApp.Services
{
    public class EmailService : IEmailService
    {
        private readonly IDataContext db;
        public EmailService(IDataContext db)
        {
            this.db = db;
        }
        public Email Create(Email emails)
        {
            var em = db.Emails.Add(emails);
            db.SaveChanges();
            return em.Entity;
        }

        public bool Delete(int id)
        {
            var em = db.Emails.FirstOrDefault(c => c.Id == id);
            db.Emails.Remove(em);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<Email> Get()
        {
            return db.Emails.ToList();
        }

        public Email Get(int id)
        {
            return db.Emails.FirstOrDefault(c => c.Id == id);
        }

        public Email Update(Email emails)
        {
            var updatedEmail = db.Emails.Update(emails);
            db.SaveChanges();
            return updatedEmail.Entity;
        }
        public Email CheckForEmail(string emailExist)
        {
            var email = db.Emails.FirstOrDefault(c => c.Emails.Equals(emailExist));
            return email;
        }
    }
}
