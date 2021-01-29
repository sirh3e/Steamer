using Sirh3e.Steamer.Core.Clients;
using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Services.SteamUser;

namespace Sirh3e.Steamer.Web.Services
{
    public interface ISteamerWebService : ISteamerService, ISteamWebSteamUserServiceBinder
    {
        ISteamerWebClient Client { get; }
    }
}