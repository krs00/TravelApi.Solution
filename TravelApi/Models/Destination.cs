namespace TravelApi.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }

    public List<Review> Reviews { get; set; } // NAVIGATION PROPERTY
}
}