using System.Net.Http;
using System.Text.Json;

namespace GiphyIntegration.Common
{
    public class RequestManager : IRequestManager
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RequestManager(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> GetAsync<T>(string url) 
        {
            
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url) { };

            var httpClient = _httpClientFactory.CreateClient();

            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                return await JsonSerializer.DeserializeAsync<T>(contentStream);
            }
            return default(T);
        }
    }
}
