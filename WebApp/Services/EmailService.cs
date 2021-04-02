using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public Emails Add(Emails emails)
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

        public List<Emails> Get()
        {
            return db.Emails.ToList();
        }

        public Emails Get(int id)
        {
            return db.Emails.FirstOrDefault(c => c.Id == id);
        }

        public Emails Update(Emails emails)
        {
            var updatedEmail = db.Emails.Update(emails);
            db.SaveChanges();
            return updatedEmail.Entity;
        }
    }
}
