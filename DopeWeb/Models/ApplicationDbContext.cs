using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DopeWeb.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Events> Events { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Subscribers> Subscribers { get; set; }
        public DbSet<Orders> Orders { get; set; }



    }
}
