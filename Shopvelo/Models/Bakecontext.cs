﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Models
{
    public class Bakecontext: DbContext
    {
        public DbSet<Bake> Bakes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public Bakecontext(DbContextOptions<Bakecontext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRole = "admin";
            string userRole = "user";
            string adminLogin = "admin@gmail.com";
            string adminPassword = "1111";
            Role admin = new Role { RoleId = 1, Name = adminRole };
            Role user = new Role { RoleId = 2, Name = userRole };
            User adminUser = new User
            {
                UserId = 123,
                Email = adminLogin,
                Password = adminPassword,
                RoleId = admin.RoleId
            };
            modelBuilder.Entity<Role>().HasData(new Role[] { admin, user });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
