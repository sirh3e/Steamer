﻿using System;
using Sirh3e.Steamer.Core.Clients.Web;
using Sirh3e.Steamer.Core.Net.Http.Clients.Providers;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.SteamUser.UserGroupList;
using Sirh3e.Steamer.Web.Pipelines;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Response;

namespace Sirh3e.Steamer.Web
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

        public ISteamerWebFriendListResponse Execute(ISteamerWebFriendListRequest request)
        {
            var response = new SteamerWebFriendListResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebPlayerBansResponse Execute(ISteamerWebPlayerBansRequest request)
        {
            var response = new SteamerWebPlayerBansResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebPlayerSummariesResponse Execute(ISteamerWebPlayerSummariesRequest request)
        {
            var response = new SteamerWebPlayerSummariesResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebResolveVanityUrlResponse Execute(ISteamerWebResolveVanityUrlRequest request)
        {
            var response = new SteamerWebResolveVanityUrlResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebUserGroupListResponse Execute(ISteamerWebUserGroupListRequest request)
        {
            var response = new SteamerWebUserGroupListResponse();

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