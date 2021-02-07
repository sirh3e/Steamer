using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request
{
    public interface IPlayerSummariesRequestBuilder : ISteamerRequestBuilder<IPlayerSummariesRequest>
    {
        public IPlayerSummariesRequestBuilder SetKey(string key);
        public IPlayerSummariesRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}