using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.ResolveVanityUrl;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Response
{
    public interface IResolveVanityUrlResponse : ISteamerResponse<IResolveVanityUrlRequest, ResponseModel<ResolveVanityUrlModel>>
    {

    }
}