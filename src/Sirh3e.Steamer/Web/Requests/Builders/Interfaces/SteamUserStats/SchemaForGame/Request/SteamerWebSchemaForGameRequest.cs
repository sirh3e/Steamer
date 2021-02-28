using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request
{
    public class SteamerWebSchemaForGameRequest : SteamerRequest, ISteamerWebSchemaForGameRequest
    {
        public SteamerWebSchemaForGameRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
                                                                                           new SteamerHttpMethodGet(),
                                                                                           "GetSchemaForGame", 2,
                                                                                           new
                                                                                               SteamerParameters(new SteamerStringParameter("key"),
                                                                                                   new SteamerU32Parameter("appid"), new SteamerStringParameter("l", false))))
        {
        }
    }
}