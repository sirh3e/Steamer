using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request
{
    public class SteamerWebCommunityBadgeProgressRequestBuilder
        : SteamerRequestBuilder<SteamerWebCommunityBadgeProgressRequestBuilder,
                ISteamerWebCommunityBadgeProgressRequest>,
            ISteamerWebCommunityBadgeProgressRequestBuilder
    {
        public SteamerWebCommunityBadgeProgressRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new SteamerWebCommunityBadgeProgressRequest(Interface ??
                                                                  throw new ArgumentNullException(nameof(Interface)));
        }

        public override ISteamerWebCommunityBadgeProgressRequest Build()
        {
            var request = Request;

            Request = new SteamerWebCommunityBadgeProgressRequest(Interface ??
                                                                  throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebCommunityBadgeProgressRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebCommunityBadgeProgressRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);

        public ISteamerWebCommunityBadgeProgressRequestBuilder SetBadgeId(int badgeId)
            => SetValue("badgeid", badgeId);
    }
}