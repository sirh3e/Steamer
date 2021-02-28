using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request
{
    public interface ISteamerWebNumberOfCurrentPlayersRequestBuilder : ISteamerRequestBuilder<ISteamerWebNumberOfCurrentPlayersRequest>
    {
        public ISteamerWebNumberOfCurrentPlayersRequestBuilder SetAppId(uint appId);
    }
}