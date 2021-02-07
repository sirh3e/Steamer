using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.SteamerWebService.Models;
using Sirh3e.Steamer.SteamerWebService.Models.ResolveVanityUrl;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response
{
    public interface IResolveVanityUrlResponse : ISteamerResponse<IResolveVanityUrlRequest, ResponseModel<ResolveVanityUrlModel>>
    {

    }
}