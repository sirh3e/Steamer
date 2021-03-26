using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request
{
    public class SteamerWebFriendListRequest : SteamerRequest, ISteamerWebFriendListRequest
    {
        public SteamerWebFriendListRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
            new SteamerHttpMethodGet(),
            "GetFriendList", 1,
            new
                SteamerParameters(new SteamerStringParameter("key"),
                    new
                        SteamerU64Parameter("steamid"))))
        {
        }
    }
}