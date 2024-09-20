using Microsoft.EntityFrameworkCore;
using MyApp.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Domain.Entities;

namespace MyApp.Infrastructure.Data
{
    public class MyAppContext : DbContext, IMyAppContext
    {
        public MyAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
        }
    }
}
