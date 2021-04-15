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
        DbSet<User> Users { get; set; }
        DbSet<Email> Emails { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserInRole> UsersInRoles { get; set; }
        int SaveChanges();
    }
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UsersInRoles { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany<Email>(emails => emails.Emails)
                .WithOne(Emails => Emails.Users)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany<UserInRole>(roles => roles.UsersInRoles)
                .WithOne(UsersInRoles => UsersInRoles.Users)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Role>()
                .HasMany<UserInRole>(roles => roles.UsersInRoles)
                .WithOne(UsersInRoles => UsersInRoles.Roles)
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }   
}
