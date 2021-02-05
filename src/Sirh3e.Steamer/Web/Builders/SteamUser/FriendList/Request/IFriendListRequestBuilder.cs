using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.FriendList.Request
{
    public interface IFriendListRequestBuilder : ISteamerBuilder<IFriendListRequest>
    {
        public IFriendListRequestBuilder SetKey(string key);
        public IFriendListRequestBuilder SetSteamId(ulong steamId);
    }
}