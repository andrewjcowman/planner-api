using WeatherAPI.Entities;

namespace WeatherAPI.Services
{
    public interface IWeatherService
    {
        Task<CurrentWeatherResponse> GetCurrentWeatherForCity(string city);
    }

    public class WeatherService : IWeatherService
    {
        private readonly string _baseUrl = "https://api.weatherstack.com/current?access_key=7f15a5552ff0602f93cb327396952a54&query=";

        public async Task<CurrentWeatherResponse> GetCurrentWeatherForCity(string city)
        {
            using var client = new HttpClient();

            var result = await client.GetFromJsonAsync<CurrentWeatherResponse>(_baseUrl + city + "&units=f");

            return result;
        }
    }
}
