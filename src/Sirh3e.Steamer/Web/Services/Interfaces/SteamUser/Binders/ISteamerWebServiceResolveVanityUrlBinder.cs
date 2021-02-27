using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser.Binders
{
    public interface ISteamerWebServiceResolveVanityUrlBinder : ISteamerServiceBinder<ISteamerWebResolveVanityUrlRequest
       ,
        ISteamerWebResolveVanityUrlResponse>
    {
    }
}