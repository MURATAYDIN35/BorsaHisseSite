using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BorsaHisseSite.Services
{
    public class HisseService
    {
        private readonly HttpClient _httpClient;
        private const string _apiKey = "cvv7fa9r01qi0bq3ei40cvv7fa9r01qi0bq3ei4g";  // Finnhub API key

        public HisseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetStockData(string symbol)
        {
            var response = await _httpClient.GetStringAsync($"https://finnhub.io/api/v1/quote?symbol={symbol}&token={_apiKey}");
            return response;
        }
    }
}
