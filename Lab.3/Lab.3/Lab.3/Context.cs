using System;
using System.Linq;
using Lab._3.ScaffoldModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab._3
{
    public class Context : DbContext
    {
        public System.Data.Entity.DbSet<MyUser> MyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var config = modelBuilder.Entity<MyUser>();
            config.ToTable("MyUsers");
            base.OnModelCreating(modelBuilder);
            
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Address;Initial Catalog=NORTHWND;Persist Security Info=True;User ID=SA;Password=**********");
            base.OnConfiguring(optionsBuilder);
        }
    }
}