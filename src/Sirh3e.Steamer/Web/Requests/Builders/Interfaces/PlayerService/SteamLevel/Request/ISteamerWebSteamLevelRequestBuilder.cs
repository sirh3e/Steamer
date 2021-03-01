using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request
{
    public interface ISteamerWebSteamLevelRequestBuilder : ISteamerRequestBuilder<ISteamerWebSteamLevelRequest>
    {
        public ISteamerWebSteamLevelRequestBuilder SetKey(string key);
        public ISteamerWebSteamLevelRequestBuilder SetSteamId(ulong steamId);
    }
}