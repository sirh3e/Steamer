using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService
{
    public interface ISteamerWebPlayerServiceInterfaceBuilder : ISteamerInterface
    {
        public ISteamerWebBadgesRequestBuilder Badges { get; }
        public ISteamerWebCommunityBadgeProgressRequestBuilder CommunityBadgeProgress { get; }
        public ISteamerWebOwnedGamesRequestBuilder OwnedGames { get; }
        public ISteamerWebRecentlyPlayedGamesRequestBuilder RecentlyPlayedGames { get; }
        public ISteamerWebSteamLevelRequestBuilder SteamLevel { get; }
    }
}