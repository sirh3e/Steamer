using System.Net.Http;

namespace Sirh3e.Steamer.Core.Net.Http.Clients.Providers
{
    public interface ISteamerHttpClientProvider
    {
        public HttpClient HttpClient { get; }
    }
}