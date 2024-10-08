using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WeatherAPI.Entities
{
    public class CurrentWeather
    {
        [JsonPropertyName("observation_time")]
        public string? ObservationTime { get; set; }

        public int? Temperature { get; set; }

        [JsonPropertyName("weather_code")]
        public int? WeatherCode { get; set; }

        [JsonPropertyName("weather_icons")]
        public List<string?> WeathersIcons { get; set; }

        [JsonPropertyName("weather_descriptions")]
        public List<string?> WeathersDescriptions { get; set; }

        [JsonPropertyName("wind_speed")]
        public int? WindSpeed { get; set; }

        [JsonPropertyName("wind_degree")]
        public int? WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string? WindDir { get; set; }

        public int? Pressure { get; set; }

        [JsonPropertyName("precip")]
        public int? Precipitation { get; set; }

        public int? Humidity { get; set; }

        public int? CloudCover { get; set; }

        public int? FeelsLike { get; set; }

        [JsonPropertyName("uv_index")]
        public int? UvIndex { get; set; }

        public int? Visibility { get; set; }
    }
}
