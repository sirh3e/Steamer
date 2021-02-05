using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Request
{
    public interface IPlayerSummariesRequestBuilder : ISteamerBuilder<IPlayerSummariesRequest>
    {
        public IPlayerSummariesRequestBuilder SetKey(string key);
        public IPlayerSummariesRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}