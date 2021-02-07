using System.Net.Http;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    public class PlayerBansRequest : SteamerRequest, IPlayerBansRequest
    {
        public ISteamerMethod Method { get; set; }

        public PlayerBansRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
                                                            HttpMethod.Get, "GetPlayerBans", 1,
                                                            new SteamerParameters(
                                                                                  new SteamerStringParameter("key"),
                                                                                  new SteamerStringParameter("steamids"))))
        {
        }
    }
}