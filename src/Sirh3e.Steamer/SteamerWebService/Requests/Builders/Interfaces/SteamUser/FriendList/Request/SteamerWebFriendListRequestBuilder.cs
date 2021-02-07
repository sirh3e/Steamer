using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.FriendList.Request
{
    public class SteamerWebFriendListRequestBuilder : SteamerRequestBuilder<SteamerWebFriendListRequestBuilder, ISteamerWebFriendListRequest>,
                                                      ISteamerWebFriendListRequestBuilder
    {
        public SteamerWebFriendListRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebFriendListRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

        public ISteamerWebFriendListRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebFriendListRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);

        public override ISteamerWebFriendListRequest Build()
        {
            var request = Request;

            Request = new SteamerWebFriendListRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

            return request;
        }
    }
}