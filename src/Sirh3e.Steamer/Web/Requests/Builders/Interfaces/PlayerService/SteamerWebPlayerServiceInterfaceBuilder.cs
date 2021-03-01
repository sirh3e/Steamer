using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService
{
    public class SteamerWebPlayerServiceInterfaceBuilder : SteamerInterface, ISteamerWebPlayerServiceInterfaceBuilder
    {
        public SteamerWebPlayerServiceInterfaceBuilder() : base("IPlayerService")
        {
            RecentlyPlayedGames = new SteamerWebRecentlyPlayedGamesRequestBuilder(this);
        }

        public ISteamerWebRecentlyPlayedGamesRequestBuilder RecentlyPlayedGames { get; }
    }
}