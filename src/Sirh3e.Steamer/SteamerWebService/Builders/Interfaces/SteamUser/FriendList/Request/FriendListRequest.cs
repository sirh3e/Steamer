using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request
{
    public class FriendListRequest : SteamerRequest, IFriendListRequest
    {
        public FriendListRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface, new SteamerHttpMethodGet(),
                                                                                        "GetFriendList", 1,
                                                                                        new SteamerParameters(new SteamerStringParameter("key"),
                                                                                            new SteamerUlongParameter("steamid"))))
        {
        }
    }
}