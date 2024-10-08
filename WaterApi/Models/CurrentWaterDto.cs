namespace WaterApi.Models
{
    public class CurrentWaterDto
    {
        public string? SiteName { get; set; }

        public float? Latitude { get; set; }

        public float? Longitude { get; set; }

        public List<CurrentWaterSourceDetails> WaterLevels { get; set; }
    }
}
