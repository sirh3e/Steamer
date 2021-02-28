using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models.SteamUserStats.SchemaForGame;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Response
{
    public interface ISteamerWebSchemaForGameResponse : ISteamerResponse<ISteamerWebSchemaForGameRequest,
        SteamerWebSchemaForGameModel>
    {
    }
}