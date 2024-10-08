using MarketApi.Models;
using MarketApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarketApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarketController : Controller
    {
        private readonly IMarketService _marketService;

        public MarketController(IMarketService marketService)
        {
            _marketService = marketService;
        }

        [HttpGet("GetCurrentMarketForTicker")]
        public async Task<CurrentMarketResponse> GetCurrentMarketForTicker(string ticker)
        {
            var response = await _marketService.GetCurrentMarketForTicker(ticker);

            return response;
        }
    }
}
