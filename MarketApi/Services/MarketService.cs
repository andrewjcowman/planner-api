using MarketApi.Models;

namespace MarketApi.Services
{
    public interface IMarketService
    {
        Task<CurrentMarketResponse> GetCurrentMarketForTicker(string ticker);
    }
    public class MarketService : IMarketService
    {
        private readonly string _baseUrl = "http://api.marketstack.com/v1/eod/latest?access_key=47b28677fb56b8ad2b052260e207ced3&symbols=";
        public async Task<CurrentMarketResponse> GetCurrentMarketForTicker(string ticker)
        {
            using var client = new HttpClient();

            var result = await client.GetFromJsonAsync<CurrentMarketResponse>(_baseUrl + ticker);

            return result;
        }
    }
}
