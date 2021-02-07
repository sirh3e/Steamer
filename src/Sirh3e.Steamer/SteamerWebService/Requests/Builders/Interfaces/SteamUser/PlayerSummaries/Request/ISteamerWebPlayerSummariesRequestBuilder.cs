using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request
{
    public interface ISteamerWebPlayerSummariesRequestBuilder : ISteamerRequestBuilder<ISteamerWebPlayerSummariesRequest>
    {
        public ISteamerWebPlayerSummariesRequestBuilder SetKey(string key);
        public ISteamerWebPlayerSummariesRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}