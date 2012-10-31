using System;
using System.Data.Entity;

namespace SimpleMembershipDemo.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name = MyDbConnection")
        { 
            this.Configuration.LazyLoadingEnabled = false; 
        }

        public DbSet<User> Users { get; set; }
    }
}