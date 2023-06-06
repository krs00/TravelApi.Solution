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

        protected override void OnModelCreating(ModelBuilder builder) // Seeded Data for API with places from Earthbound
        {
            // builder.Entity<Destination>()
            //   .HasData(
        
            //   );

            // builder.Entity<Review>()
            //   .HasData(
            
            //   );

            // builder.Entity<User>()
            //   .HasData(
        
            //   );

        }




    }
}