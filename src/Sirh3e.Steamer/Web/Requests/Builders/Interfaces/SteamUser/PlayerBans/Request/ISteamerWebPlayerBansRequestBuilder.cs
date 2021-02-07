using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    public interface ISteamerWebPlayerBansRequestBuilder : ISteamerRequestBuilder<ISteamerWebPlayerBansRequest>
    {
        public ISteamerWebPlayerBansRequestBuilder SetKey(string key);
        public ISteamerWebPlayerBansRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}