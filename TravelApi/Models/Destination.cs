namespace TravelApi.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; } 

        public List<Review> Reviews { get; set; } // NAVIGATION PROPERTY
    }
}