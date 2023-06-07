namespace TravelApi.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public List<Review> Reviews { get; set;}

    }
}