namespace TravelApi.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
        public int DestinationId { get; set; } // FOREIGN KEY
    }
}