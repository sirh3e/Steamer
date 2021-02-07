using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request
{
    public interface ISteamerWebUserGroupListRequestBuilder : ISteamerRequestBuilder<ISteamerWebUserGroupListRequest>
    {
        public ISteamerWebUserGroupListRequestBuilder SetKey(string key);
        public ISteamerWebUserGroupListRequestBuilder SetSteamId(ulong steamId);
    }
}