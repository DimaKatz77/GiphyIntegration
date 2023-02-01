using GiphyIntegration.Api.Response;
using System.Net;

namespace GiphyIntegration.Api.Client
{
    public interface IClient
    {
        List<string>? GetTrending();
        List<string>? GetSearch(string query);
    }
}
