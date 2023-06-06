using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder) // Seeded Data for API with places from Earthbound
    {
      builder.Entity<Destination>()
        .HasData(
          new Destination { DestinationId = 1, Name = "Onett", Location = "Eagleland", Description = "Small town" },
          new Destination { DestinationId = 2, Name = "Twoson", Location = "Eagleland", Description = "Big town" },
          new Destination { DestinationId = 3, Name = "Magicant", Location = "Dreamland", Description = "Quirky" },
          new Destination { DestinationId = 4, Name = "Dalaam", Location = "Chommo", Description = "Rural village" }
        );

      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, DestinationId = 1, Comment = "Kind of boring", Rating = 8, Date = DateTime.Now },
          new Review { ReviewId = 2, DestinationId = 2, Comment = "cool place", Rating = 5, Date = DateTime.Now },
          new Review { ReviewId = 3, DestinationId = 3, Comment = "Weird", Rating = 6, Date = DateTime.Now },
          new Review { ReviewId = 4, DestinationId = 4, Comment = "good vibes", Rating = 5, Date = DateTime.Now }
        );
    }




  }
}