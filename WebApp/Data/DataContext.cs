using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;

namespace WebApp.Data
{
    public interface IDataContext
    {
        DbSet<Users> Users { get; set; }
        DbSet<Emails> Emails { get; set; }
        DbSet<Roles> Roles { get; set; }
        DbSet<UsersInRoles> UsersInRoles { get; set; }
        int SaveChanges();
    }
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Emails> Emails { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UsersInRoles> UsersInRoles { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DataContext()
        {

        }
    }   
}
