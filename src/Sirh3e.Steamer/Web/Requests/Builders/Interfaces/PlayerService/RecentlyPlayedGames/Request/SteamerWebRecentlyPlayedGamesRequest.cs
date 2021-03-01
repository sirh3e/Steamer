using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.RecentlyPlayedGames.Request
{
    public class SteamerWebRecentlyPlayedGamesRequest : SteamerRequest, ISteamerWebRecentlyPlayedGamesRequest
    {
        public SteamerWebRecentlyPlayedGamesRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
                                                                                           new SteamerHttpMethodGet(),
                                                                                           "GetRecentlyPlayedGames", 1,
                                                                                           new
                                                                                               SteamerParameters(new SteamerStringParameter("key"),
                                                                                                   new
                                                                                                       SteamerU64Parameter("steamid"), new SteamerU32Parameter("count", false))))
        {
        }
    }
}