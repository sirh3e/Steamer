using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.FriendList.Request
{
    public class FriendListRequestBuilder : SteamerRequestBuilder<FriendListRequestBuilder, IFriendListRequest>,
                                            IFriendListRequestBuilder
    {
        public FriendListRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new FriendListRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));
        }

        public IFriendListRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public IFriendListRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);

        public override IFriendListRequest Build()
        {
            var request = Request;

            Request = new FriendListRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

            return request;
        }
    }
}