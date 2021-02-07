using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response;

namespace Sirh3e.Steamer.Web.Services.SteamUser
{
    public interface ISteamerWebServiceResolveVanityUrlBinder : ISteamerServiceBinder<IResolveVanityUrlRequest,
        IResolveVanityUrlResponse>
    {

    }
}