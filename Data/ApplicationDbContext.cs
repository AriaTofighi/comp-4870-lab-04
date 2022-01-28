using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab04.Data;
using Lab04.Models;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
        modelBuilder.Entity<City>().HasData(SampleData.GetCities());
    }


    public DbSet<Province>? Provinces { get; set; }
    public DbSet<City>? Cities { get; set; }
}
