namespace GiphyIntegration.Common
{
    public interface IRequestManager
    {
        Task<T> GetAsync<T>(string url);
    }
}
