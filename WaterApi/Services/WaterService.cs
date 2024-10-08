using WaterApi.Models;

namespace WaterApi.Services
{
    public interface IWaterService
    {
        Task<CurrentWaterResponse> GetCurrentWater();
    }

    public class WaterService : IWaterService
    {
        private readonly string _baseUrl = "https://nwis.waterservices.usgs.gov/nwis/iv/?format=json&sites=06481500&startDT=2024-05-27T12:00&endDT=2024-05-28T12:00&siteStatus=all";
        
        public async Task<CurrentWaterResponse> GetCurrentWater()
        {
            using var client = new HttpClient();

            var result = await client.GetFromJsonAsync<CurrentWaterResponse>(_baseUrl);

            return result;
        }
    }
}
