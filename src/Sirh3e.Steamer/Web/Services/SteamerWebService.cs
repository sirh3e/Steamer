using System;
using Sirh3e.Steamer.Core.Clients;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Net.Http;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Pipelines.SteamerWebService;

namespace Sirh3e.Steamer.Web.Services
{
    public class SteamerWebService : ISteamerWebService
    {
        public SteamerWebService(ISteamerWebClient webClient, ISteamerHttpClientProvider httpClientProvider)
        {
            WebClient = webClient ?? throw new ArgumentNullException(nameof(webClient));
            HttpClientProvider = httpClientProvider ?? throw new ArgumentNullException(nameof(httpClientProvider));
        }

        public ISteamerWebClient WebClient { get; }
        public ISteamerHttpClientProvider HttpClientProvider { get; set; }

        public IPlayerBansResponse Execute(IPlayerBansRequest request)
        {
            var response = new PlayerBansResponse();

            var pipeline = CreatePipeline(response, response.Model.Unwrap);
            return pipeline.Process(request);
        }

        public void Dispose()
        {
            HttpClientProvider.HttpClient?.Dispose();
        }

        private SteamerWebServicePipeline<TSteamerResponse, TSteamerResponseModel> CreatePipeline<TSteamerResponse,
            TSteamerResponseModel>(TSteamerResponse response, Func<TSteamerResponseModel> model)
            where TSteamerResponse : ISteamerResponse<TSteamerResponseModel>, new()
        {
            return new(this);
        }
    }
}