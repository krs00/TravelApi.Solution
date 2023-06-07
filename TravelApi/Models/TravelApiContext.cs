using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
            .HasData(

                new City { CityId = 1, Name = "Portland", Country = "USA", Description = "Rainy" },
                new City { CityId = 2, Name = "Seattle", Country = "USA", Description = "Very Rainy" },
                new City { CityId = 3, Name = "Austin", Country = "USA", Description = "Hot" },
                new City { CityId = 4, Name = "Tokyo", Country = "Japan", Description = "Cool" },
                new City { CityId = 5, Name = "Osaka", Country = "Japan", Description = "Looks Cool" });

            builder.Entity<Review>()
            .HasData(

              new Review { ReviewId = 1, Message = "An okay city", Rating = 5, UserId = 1, CityId = 1 }
            );

            builder.Entity<User>()
            .HasData(

            new User { UserId = 1, Name = "Kymani"}

            );



        }
    }
}