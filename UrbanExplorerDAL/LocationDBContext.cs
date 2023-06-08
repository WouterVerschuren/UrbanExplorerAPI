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
        optionsBuilder.UseSqlServer("Server=tcp:urbanexplorerserver.database.windows.net,1433;Initial Catalog=urbanexplorerdb;Persist Security Info=False;User ID=UrbanExplorer;Password=QRHHpe4y;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"); // Replace with your actual database connection string
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LocationDTO>()

            .Property(e => e.Checked)
            .HasConversion<byte>();
    }

}
