using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request
{
    public class SteamerWebUserGroupListRequestBuilder :
        SteamerRequestBuilder<SteamerWebUserGroupListRequestBuilder, ISteamerWebUserGroupListRequest>,
        ISteamerWebUserGroupListRequestBuilder
    {
        public SteamerWebUserGroupListRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebUserGroupListRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebUserGroupListRequest Build()
        {
            var request = Request;

            Request = new SteamerWebUserGroupListRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebUserGroupListRequestBuilder SetKey(string key) => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebUserGroupListRequestBuilder SetSteamId(ulong steamId) => SetValue("steamid", steamId);
    }
}