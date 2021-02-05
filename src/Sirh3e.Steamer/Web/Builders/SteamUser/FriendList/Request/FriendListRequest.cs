using Sirh3e.Steamer.Core.Method;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Request
{
    public class FriendListRequest : IFriendListRequest
    {
        public ISteamerMethod Method { get; set; }
    }
}