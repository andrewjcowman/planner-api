namespace WaterApi.Models
{
    public class GeoLocation
    {
        public GeogLocation GeogLocation { get; set; }
    }

    public class GeogLocation
    {
        public float? Latitude { get; set; }

        public float? Longitude { get; set; }
    }
}
