using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Web.Models.SteamUserStats.SchemaForGame;
using Sirh3e.Steamer.Web.Models.SteamUserStats.UserStatsForGame;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Response
{
    public class SteamerWebSchemaForGameResponse : ISteamerWebSchemaForGameResponse
    {
        public ISteamerWebSchemaForGameRequest Request { get; init; }
        public Option<SteamerWebSchemaForGameModel> Model { get; init; }
    }
}