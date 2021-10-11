using Microsoft.EntityFrameworkCore;
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
        public Bakecontext(DbContextOptions<Bakecontext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
