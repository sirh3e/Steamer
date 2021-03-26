using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request
{
    public interface
        ISteamerWebCommunityBadgeProgressRequestBuilder : ISteamerRequestBuilder<
            ISteamerWebCommunityBadgeProgressRequest>
    {
        public ISteamerWebCommunityBadgeProgressRequestBuilder SetKey(string key);
        public ISteamerWebCommunityBadgeProgressRequestBuilder SetSteamId(ulong steamId);
        public ISteamerWebCommunityBadgeProgressRequestBuilder SetBadgeId(int badgeId);
    }
}