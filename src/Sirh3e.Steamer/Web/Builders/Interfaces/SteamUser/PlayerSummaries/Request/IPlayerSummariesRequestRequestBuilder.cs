using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerSummaries.Request
{
    public interface IPlayerSummariesRequestRequestBuilder : ISteamerRequestBuilder<IPlayerSummariesRequest>
    {
        public IPlayerSummariesRequestRequestBuilder SetKey(string key);
        public IPlayerSummariesRequestRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}