using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace pos_system.Model
{
    public class DatabaseContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-SEJCFC3;Database=POSDB2;Trusted_Connection=true";

        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public  DbSet<Sale> Sales { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
