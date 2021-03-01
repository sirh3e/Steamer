using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService
{
    public class SteamerWebPlayerServiceInterfaceBuilder : SteamerInterface, ISteamerWebPlayerServiceInterfaceBuilder
    {
        public SteamerWebPlayerServiceInterfaceBuilder() : base("IPlayerService")
        {
            Badges = new SteamerWebBadgesRequestBuilder(this);
            OwnedGames = new SteamerWebOwnedGamesRequestBuilder(this);
            RecentlyPlayedGames = new SteamerWebRecentlyPlayedGamesRequestBuilder(this);
            SteamLevel = new SteamerWebSteamLevelRequestBuilder(this);
        }

        public ISteamerWebBadgesRequestBuilder Badges { get; }
        public ISteamerWebOwnedGamesRequestBuilder OwnedGames { get; }
        public ISteamerWebRecentlyPlayedGamesRequestBuilder RecentlyPlayedGames { get; }
        public ISteamerWebSteamLevelRequestBuilder SteamLevel { get; }
    }
}