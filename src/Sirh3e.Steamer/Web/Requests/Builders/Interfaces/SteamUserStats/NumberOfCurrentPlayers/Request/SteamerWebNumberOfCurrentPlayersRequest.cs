using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.NumberOfCurrentPlayers.Request
{
    public class SteamerWebNumberOfCurrentPlayersRequest : SteamerRequest, ISteamerWebNumberOfCurrentPlayersRequest
    {
        public SteamerWebNumberOfCurrentPlayersRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
                                                                                           new SteamerHttpMethodGet(),
                                                                                           "GetNumberOfCurrentPlayers", 1,
                                                                                           new
                                                                                               SteamerParameters(
                                                                                                   new SteamerU32Parameter("appid")
                                                                                                   )))
        {
        }
    }
}