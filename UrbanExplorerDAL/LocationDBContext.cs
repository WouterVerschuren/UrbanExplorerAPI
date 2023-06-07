using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UrbanExplorerDTO;

public class LocationDBContext : DbContext
{
    public DbSet<LocationDTO>? Locations { get; set; }

    public LocationDBContext() 
    { 
    }

    public LocationDBContext(DbContextOptions<LocationDBContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=LAPTOP-MOO8TEUR\\SPOTIFY2;Initial Catalog=UrbanExplorer;Integrated Security=True;TrustServerCertificate=True"); // Replace with your actual database connection string
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LocationDTO>()

            .Property(e => e.Checked)
            .HasConversion<byte>();
    }

}
