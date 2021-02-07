using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Request
{
    public interface IFriendListRequestBuilder : ISteamerRequestBuilder<IFriendListRequest>
    {
        public IFriendListRequestBuilder SetKey(string key);
        public IFriendListRequestBuilder SetSteamId(ulong steamId);
    }
}