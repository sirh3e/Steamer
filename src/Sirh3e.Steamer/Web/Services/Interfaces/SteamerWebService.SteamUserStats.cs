using System.Threading.Tasks;
using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;
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
        public Task<Result<ISteamerWebGlobalAchievementPercentagesForAppResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebGlobalAchievementPercentagesForAppRequest request)
        {
            var response = new SteamerWebGlobalAchievementPercentagesForAppResponse();

            return MapAsync<SteamerWebGlobalAchievementPercentagesForAppResponse,
                ISteamerWebGlobalAchievementPercentagesForAppResponse>(ExecuteAsync(request, response,
                response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebNumberOfCurrentPlayersResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebNumberOfCurrentPlayersRequest request)
        {
            var response = new SteamerWebNumberOfCurrentPlayersResponse();

            return MapAsync<SteamerWebNumberOfCurrentPlayersResponse, ISteamerWebNumberOfCurrentPlayersResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebPlayerAchievementsResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebPlayerAchievementsRequest request)
        {
            var response = new SteamerWebPlayerAchievementsResponse();

            return MapAsync<SteamerWebPlayerAchievementsResponse, ISteamerWebPlayerAchievementsResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebSchemaForGameResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebSchemaForGameRequest request)
        {
            var response = new SteamerWebSchemaForGameResponse();

            return MapAsync<SteamerWebSchemaForGameResponse, ISteamerWebSchemaForGameResponse>(ExecuteAsync(request,
                response, response.Model.Unwrap));
        }

        public Task<Result<ISteamerWebUserStatsForGameResponse, ISteamerWebError>> ExecuteAsync(
            ISteamerWebUserStatsForGameRequest request)
        {
            var response = new SteamerWebUserStatsForGameResponse();

            return MapAsync<SteamerWebUserStatsForGameResponse, ISteamerWebUserStatsForGameResponse>(
                ExecuteAsync(request, response, response.Model.Unwrap));
        }
    }
}