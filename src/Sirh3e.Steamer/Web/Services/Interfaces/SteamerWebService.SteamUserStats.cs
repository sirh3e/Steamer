using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.UserStatsForGame.Response;

namespace Sirh3e.Steamer.Web.Services
{
    public partial class SteamerWebService : ISteamerWebService
    {
        public ISteamerWebUserStatsForGameResponse Execute(ISteamerWebUserStatsForGameRequest request)
        {
            var response = new SteamerWebUserStatsForGameResponse();

            return GetResponse(request, response, response.Model.Unwrap);
        }
    }
}