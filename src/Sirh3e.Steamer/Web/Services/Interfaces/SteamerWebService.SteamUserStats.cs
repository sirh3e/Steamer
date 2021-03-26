using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.GlobalAchievementPercentagesForApp.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.PlayerAchievements.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Response;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public ISteamerWebGlobalAchievementPercentagesForAppResponse Execute(
            ISteamerWebGlobalAchievementPercentagesForAppRequest request)
        {
            var response = new SteamerWebGlobalAchievementPercentagesForAppResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebNumberOfCurrentPlayersResponse Execute(ISteamerWebNumberOfCurrentPlayersRequest request)
        {
            var response = new SteamerWebNumberOfCurrentPlayersResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebPlayerAchievementsResponse Execute(ISteamerWebPlayerAchievementsRequest request)
        {
            var response = new SteamerWebPlayerAchievementsResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebSchemaForGameResponse Execute(ISteamerWebSchemaForGameRequest request)
        {
            var response = new SteamerWebSchemaForGameResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }

        public ISteamerWebUserStatsForGameResponse Execute(ISteamerWebUserStatsForGameRequest request)
        {
            var response = new SteamerWebUserStatsForGameResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}