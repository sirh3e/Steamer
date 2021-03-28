using System;
using System.Net.Http;

namespace Sirh3e.Steamer.Core.Net.Http.Clients.Providers
{
    public class SteamerHttpClientProvider : ISteamerHttpClientProvider
    {
        public SteamerHttpClientProvider(HttpClient httpClient)
        {
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public HttpClient HttpClient { get; }

        public class Builder
        {
            public HttpClient? HttpClient { get; protected set; }

            public Builder SetHttpClient(HttpClient httpClient)
            {
                HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            public SteamerHttpClientProvider Build()
                => new(HttpClient ?? new HttpClient());

            public static implicit operator SteamerHttpClientProvider(Builder builder)
                => builder.Build();
        }

        public static class Factory
        {
            public static SteamerHttpClientProvider CreateDefault()
                => new Builder().SetHttpClient(new HttpClient()).Build();
        }
    }
}