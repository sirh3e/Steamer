using System.Net.Http;

namespace Sirh3e.Steamer.Net.Http
{
    public interface ISteamerHttpClientProvider
    {
        public HttpClient HttpClient { get; }
    }
}