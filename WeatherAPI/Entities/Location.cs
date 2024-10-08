using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WeatherAPI.Entities
{
    public class Location
    {
        public string? Name { get; set; }

        public string? Country { get; set; }

        public string? Region { get; set; }

        [JsonPropertyName("Lat")]
        public string? Latitude { get; set; }

        [JsonPropertyName("Lon")]
        public string? Longitude { get; set; }

        [JsonPropertyName("timezone_id")]
        public string? TimeZoneId { get; set; }

        public string? LocalTime { get; set; }

    }
}
