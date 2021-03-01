using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request
{
    public class SteamerWebBadgesRequestBuilder
        : SteamerRequestBuilder<SteamerWebBadgesRequestBuilder, ISteamerWebBadgesRequest>,
            ISteamerWebBadgesRequestBuilder
    {
        public SteamerWebBadgesRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebBadgesRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebBadgesRequest Build()
        {
            var request = Request;

            Request = new SteamerWebBadgesRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebBadgesRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebBadgesRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);
    }
}