using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.SteamUserStats.PlayerAchievements;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Response
{
    public class SteamerWebPlayerAchievementsResponse : ISteamerWebPlayerAchievementsResponse
    {
        public ISteamerWebPlayerAchievementsRequest Request { get; init; }
        public Option<SteamerWebPlayerAchievementsModel> Model { get; init; }
    }
}