using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace MyFabricStashWebAppCore4.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public DbSet<Fabric> Fabrics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //See Pro Entity Framework Core 2 book by Adam Freeman (Apress) p.543
            modelBuilder.Entity<Fabric>().Property<DateTime>("LastUpdated")
                .HasDefaultValue(System.DateTime.Now);
        }
    }
}
