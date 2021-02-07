using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request
{
    public class PlayerSummariesRequest : SteamerRequest, IPlayerSummariesRequest
    {
        public PlayerSummariesRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
                                                                                             new SteamerHttpMethodGet(), "GetPlayerSummaries", 2,
                                                                                             new SteamerParameters(
                                                                                              new SteamerStringParameter("key"),
                                                                                              new SteamerStringParameter("steamids"))))
        {
        }
    }
}