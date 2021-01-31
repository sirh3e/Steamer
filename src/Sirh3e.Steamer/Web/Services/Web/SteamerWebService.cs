using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Net.Http;
using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries;
using Sirh3e.Steamer.Web.Pipelines.SteamerWebService;

namespace Sirh3e.Steamer.Web.Services.Web
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

        public void Dispose()
        {
            HttpClientProvider.HttpClient?.Dispose();
        }

        public IFriendListResponse Execute(IFriendListRequest request)
        {
            var response = new FriendListResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public IPlayerBansResponse Execute(IPlayerBansRequest request)
        {
            var response = new PlayerBansResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public IPlayerSummariesResponse Execute(IPlayerSummariesRequest request)
        {
            var response = new PlayerSummariesResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        private TSteamerResponse GetResponse<TRequest, TSteamerResponse, TSteamerResponseModel>(TRequest request,
            TSteamerResponse response, Func<TSteamerResponseModel> model)
            where TRequest : ISteamerRequest
            where TSteamerResponse : ISteamerResponse<TSteamerResponseModel>, new()
        {
            return CreatePipeline<TSteamerResponse, TSteamerResponseModel>().Process(request);
        }

        private SteamerWebServicePipeline<TSteamerResponse, TSteamerResponseModel> CreatePipeline<TSteamerResponse,
            TSteamerResponseModel>()
            where TSteamerResponse : ISteamerResponse<TSteamerResponseModel>, new()
        {
            return new(this);
        }
    }
}