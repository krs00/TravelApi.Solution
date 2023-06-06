namespace TravelApi.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }


        public int DestinationId { get; set; } // FOREIGN KEY
        public Destination Destination { get; set; } // NAVIGATION PROPERTY

        public int UserId { get; set; } // FOREIGN KEY
        public User User { get; set; } // NAVIGATION PROPERTY
    }
}