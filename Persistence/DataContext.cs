using System;
using Domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<value>()
            .HasData(
            new value { Id = 1, name = "Value 101" },
            new value { Id = 2, name = "Value 102" },
            new value { Id = 3, name = "Value 103" }
            );
        }
    }
}
