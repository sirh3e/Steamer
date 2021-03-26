using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public class Builder
        {
            public ISteamerWebClient? WebClient { get; protected set; }
            public ISteamerHttpClientProvider? HttpClientProvider { get; protected set; }

            public Builder SetWebClient(ISteamerWebClient steamerWebClient)
            {
                WebClient = steamerWebClient ?? throw new ArgumentNullException(nameof(steamerWebClient));
                return this;
            }

            public Builder SetHttpClientProvider(ISteamerHttpClientProvider steamerHttpClientProvider)
            {
                HttpClientProvider = steamerHttpClientProvider ?? throw new ArgumentNullException(nameof(steamerHttpClientProvider));
                return this;
            }

            public SteamerWebService Build()
                => new(
                    WebClient ?? throw new ArgumentNullException(nameof(WebClient)),
                    HttpClientProvider ?? throw new ArgumentNullException(nameof(HttpClientProvider)));

            public static implicit operator SteamerWebService(Builder builder)
                => (_ = builder ?? throw new ArgumentNullException(nameof(builder))).Build();
        }
    }
}