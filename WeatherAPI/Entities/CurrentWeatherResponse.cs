using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WeatherAPI.Entities
{
    public class CurrentWeatherResponse
    {
        public Location? Location { get; set; }

        [JsonPropertyName("current")]
        public CurrentWeather? CurrentWeather { get; set; }
    }
}
