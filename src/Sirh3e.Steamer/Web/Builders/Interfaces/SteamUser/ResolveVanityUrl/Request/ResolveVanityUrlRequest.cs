using System.Net.Http;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request
{
    public class ResolveVanityUrlRequest : SteamerRequest, IResolveVanityUrlRequest
    {
        public ResolveVanityUrlRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface, HttpMethod.Get, "ResolveVanityUrl", 1, new SteamerParameters(
                                                                                               new SteamerStringParameter("key"),
                                                                                                  new SteamerStringParameter("vanityurl"),
                                                                                               new SteamerStringParameter("url_type", false)
                                                                                               )))
        {
        }
    }
}