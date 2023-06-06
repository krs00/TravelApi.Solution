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

            builder.Entity<Review>()
              .HasData(
                new Review { ReviewId = 1, Message = "Cool spot!", Rating = 5, Date = DateTime.Now, DestinationId = 1, UserId = 2 },
                new Review { ReviewId = 2, Message = "Very Busy Place!", Rating = 7, Date = DateTime.Now, DestinationId = 4, UserId = 3 },
                new Review { ReviewId = 3, Message = "Woah nice views!", Rating = 10, Date = DateTime.Now, DestinationId = 3, UserId = 2 },
                new Review { ReviewId = 4, Message = "A good place to learn how to program", Rating = 6, Date = DateTime.Now, DestinationId = 1, UserId = 1 }

              );

            builder.Entity<User>()
              .HasData(

                new User { UserId = 1, Name = "Kymani" },
                new User { UserId = 2, Name = "Qayden" },
                new User { UserId = 3, Name = "Renee" }

              );

        }




    }
}