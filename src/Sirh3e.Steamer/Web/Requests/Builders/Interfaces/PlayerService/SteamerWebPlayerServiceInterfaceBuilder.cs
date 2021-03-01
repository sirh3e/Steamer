using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService
{
    public class SteamerWebPlayerServiceInterfaceBuilder : SteamerInterface, ISteamerWebPlayerServiceInterfaceBuilder
    {
        public SteamerWebPlayerServiceInterfaceBuilder() : base("IPlayerService")
        {
            OwnedGames = new SteamerWebOwnedGamesRequestBuilder(this);
            RecentlyPlayedGames = new SteamerWebRecentlyPlayedGamesRequestBuilder(this);
        }

        public ISteamerWebOwnedGamesRequestBuilder OwnedGames { get; }
        public ISteamerWebRecentlyPlayedGamesRequestBuilder RecentlyPlayedGames { get; }
    }
}