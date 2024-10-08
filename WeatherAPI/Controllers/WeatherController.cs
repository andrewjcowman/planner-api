using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Entities;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("GetCurrentWeatherForCity")]
        public async Task<CurrentWeatherResponse> GetCurrentWeatherForCity(string city)
        {
            var response = await _weatherService.GetCurrentWeatherForCity(city);

            return response;
        }
    }
}
