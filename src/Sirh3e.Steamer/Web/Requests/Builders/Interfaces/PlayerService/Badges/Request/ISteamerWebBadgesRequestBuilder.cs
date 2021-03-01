using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request
{
    public interface ISteamerWebBadgesRequestBuilder : ISteamerRequestBuilder<ISteamerWebBadgesRequest>
    {
        public ISteamerWebBadgesRequestBuilder SetKey(string key);
        public ISteamerWebBadgesRequestBuilder SetSteamId(ulong steamId);
    }
}