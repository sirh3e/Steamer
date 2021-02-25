using System;
using System.Linq;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request
{
    public class SteamerWebPlayerSummariesRequestBuilder :
        SteamerRequestBuilder<SteamerWebPlayerSummariesRequestBuilder, ISteamerWebPlayerSummariesRequest>,
        ISteamerWebPlayerSummariesRequestBuilder
    {
        public SteamerWebPlayerSummariesRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request =
                new SteamerWebPlayerSummariesRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

        public ISteamerWebPlayerSummariesRequestBuilder SetKey(string key) => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        //ToDo change parameter to / create a parameter for list
        public ISteamerWebPlayerSummariesRequestBuilder SetSteamIds(params ulong[] steamIds) =>
            SetValue("steamids",
                     string.Join(",",
                                 steamIds.Select(steamId => steamId.ToString()).ToList() ??
                                 throw new ArgumentNullException(nameof(steamIds))));

        public override ISteamerWebPlayerSummariesRequest Build()
        {
            var request = Request;

            Request = new SteamerWebPlayerSummariesRequest(Interface ??
                                                           throw new ArgumentNullException(nameof(Interface)));

            return request;
        }
    }
}