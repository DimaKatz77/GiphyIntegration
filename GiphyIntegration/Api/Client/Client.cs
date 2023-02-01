
using GiphyIntegration.Api.Response;
using GiphyIntegration.Common;
using Microsoft.Extensions.Caching.Memory;

namespace GiphyIntegration.Api.Client
{
    public class Client : IClient
    {
        private readonly IConfiguration _configuration;
        private readonly IRequestManager _requestManager;
        private readonly IMemoryCache _memoryCache;

        public Client(IConfiguration configuration,
            IRequestManager requestManager, 
            IMemoryCache memoryCache)
        {
            _configuration = configuration;
            _requestManager = requestManager;
            _memoryCache = memoryCache;
        }

        public List<string>? GetSearch(string query)
        {

            List<string>? result = null;

            if (_memoryCache.TryGetValue(query,out result))
            {
                return result;
            }

            var response = _requestManager.GetAsync<GiphyResponse>(GetUrl(RequestType.search, query)).Result;           

            result = response.data.Select(c => c.url).ToList();

            _memoryCache.Set(query, result);

            return result;
        }

        public List<string>? GetTrending()
        {

            List<string>? result = null;

            string apiKey = _configuration.GetValue<string>("ApiKey");

            int limit = _configuration.GetValue<int>("limit");

            string url = $"{Settings.GiphyApiUrl}/v1/gifs/trending?api_key={apiKey}&limit={limit}";

            var response = _requestManager.GetAsync<GiphyResponse>(GetUrl(RequestType.trending)).Result;

            result = response.data.Select(c => c.url).ToList();


            return result;
        }

        private string GetUrl(RequestType type, string query = null)
        {
            string search = string.Empty;
            if (type is RequestType.search)
                search = $"&q={query}";

            string apiKey = _configuration.GetValue<string>("ApiKey");

            int limit = _configuration.GetValue<int>("limit");

            string url = $"{Settings.GiphyApiUrl}/v1/gifs/{type.ToString()}?api_key={apiKey}&limit={limit}{search}";

            return url;
        }
    }
}
