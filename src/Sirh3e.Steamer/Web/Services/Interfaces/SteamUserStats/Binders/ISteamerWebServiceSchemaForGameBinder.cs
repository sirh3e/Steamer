using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUserStats.Binders
{
    public interface ISteamerWebServiceSchemaForGameBinder
        : ISteamerServiceBinder<ISteamerWebSchemaForGameRequest, ISteamerWebSchemaForGameResponse>
    {
    }
}