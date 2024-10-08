using Microsoft.AspNetCore.Mvc;
using WaterApi.Models;
using WaterApi.Services;

namespace WaterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WaterController : Controller
    {
        private readonly IWaterService _waterService;

        public WaterController(IWaterService waterService)
        {
            _waterService = waterService;
        }

        [HttpGet("GetCurrentWater")]
        public async Task<CurrentWaterDto> GetCurrentWater()
        {
            var response = await _waterService.GetCurrentWater();

            return new CurrentWaterDto
            {
                SiteName = response.Value.TimeSeries[0].SourceInfo.SiteName,
                Latitude = response.Value.TimeSeries[0].SourceInfo.GeoLocation.GeogLocation.Latitude,
                Longitude = response.Value.TimeSeries[0].SourceInfo.GeoLocation.GeogLocation.Longitude,
                WaterLevels = response.Value.TimeSeries[0].SourceDetailsWrapper[0].SourceDetails
            };
        }
    }
}
