using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;
using Sirh3e.Steamer.SteamerWebService.Pipelines;

namespace Sirh3e.Steamer.SteamerWebService
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

        public void Dispose() => HttpClientProvider.HttpClient.Dispose();

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

        public IResolveVanityUrlResponse Execute(IResolveVanityUrlRequest request)
        {
            var response = new ResolveVanityUrlResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        private TSteamerResponse GetResponse<TRequest, TSteamerResponse, TSteamerResponseModel>(
            TRequest request,
            TSteamerResponse response,
            Func<TSteamerResponseModel> model)
            where TRequest : ISteamerRequest
            where TSteamerResponse : ISteamerResponse<TRequest, TSteamerResponseModel>, new() =>
            CreatePipeline<TRequest, TSteamerResponse, TSteamerResponseModel>().Process(request);

        private SteamerWebServicePipeline<TRequest, TSteamerResponse, TSteamerResponseModel> CreatePipeline
            <TRequest, TSteamerResponse, TSteamerResponseModel>()
            where TRequest : ISteamerRequest
            where TSteamerResponse : ISteamerResponse<TRequest, TSteamerResponseModel>, new() => new(this);
    }
}