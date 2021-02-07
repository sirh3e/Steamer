using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;

namespace Sirh3e.Steamer.SteamerWebService.Services.SteamUser
{
    public interface ISteamerWebServiceResolveVanityUrlBinder : ISteamerServiceBinder<ISteamerWebResolveVanityUrlRequest,
        ISteamerWebResolveVanityUrlResponse>
    {
    }
}