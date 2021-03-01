using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService
{
    public interface ISteamerWebPlayerServiceInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebRecentlyPlayedGamesRequestBuilder RecentlyPlayedGames { get; }
    }
}