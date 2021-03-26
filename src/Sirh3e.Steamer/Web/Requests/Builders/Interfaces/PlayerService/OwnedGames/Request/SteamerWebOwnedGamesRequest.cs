using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.OwnedGames.Request
{
    public class SteamerWebOwnedGamesRequest : SteamerRequest, ISteamerWebOwnedGamesRequest
    {
        public SteamerWebOwnedGamesRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
            new SteamerHttpMethodGet(),
            "GetOwnedGames", 1,
            new
                SteamerParameters(new SteamerStringParameter("key"),
                    new
                        SteamerU64Parameter("steamid"), new SteamerBooleanParameter("include_appinfo"),
                    new SteamerBooleanParameter("include_played_free_games"),
                    new SteamerU32Parameter("appids_filter"))))
        {
        }
    }
}