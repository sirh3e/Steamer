using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request
{
    public class SteamerWebNumberOfCurrentPlayersRequestBuilder
        : SteamerRequestBuilder<SteamerWebNumberOfCurrentPlayersRequestBuilder,
                ISteamerWebNumberOfCurrentPlayersRequest>,
            ISteamerWebNumberOfCurrentPlayersRequestBuilder
    {
        public SteamerWebNumberOfCurrentPlayersRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new SteamerWebNumberOfCurrentPlayersRequest(Interface ??
                                                                  throw new ArgumentNullException(nameof(Interface)));
        }

        public override ISteamerWebNumberOfCurrentPlayersRequest Build()
        {
            var request = Request;

            Request = new SteamerWebNumberOfCurrentPlayersRequest(Interface ??
                                                                  throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebNumberOfCurrentPlayersRequestBuilder SetAppId(uint appId)
            => SetValue("appid", appId);
    }
}