using System;
using System.Net.Http;

namespace Sirh3e.Steamer.Net.Http {
    public class SteamerHttpClientProvider : ISteamerHttpClientProvider {
        public SteamerHttpClientProvider(HttpClient httpClient) {
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public HttpClient HttpClient { get; }
    }
}