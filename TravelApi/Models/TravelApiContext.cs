using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Destination>()
              .HasData(

                new Destination { DestinationId = 1, Name = "Epicodus", City = "Portland", Country = "USA", Description = "A programming school" },
                new Destination { DestinationId = 2, Name = "Pioneer Square", City = "Portland", Country = "USA", Description = "City center" },
                new Destination { DestinationId = 3, Name = "Council Crest", City = "Portland", Country = "USA", Description = "City Park" },

                new Destination { DestinationId = 4, Name = "Shibuya Crossing", City = "Tokyo", Country = "Japan", Description = "Pedestrian Scramble" },
                new Destination { DestinationId = 5, Name = "Tokyo Tower", City = "Tokyo", Country = "Japan", Description = "Lookout Point" } 

              );



        }
    }
}