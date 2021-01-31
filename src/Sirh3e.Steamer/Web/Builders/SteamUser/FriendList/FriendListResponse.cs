using Sirh3e.Rust.Option;
using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Web.Models.FriendList;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.FriendList
{
    public class FriendListResponse : IFriendListResponse
    {
        public ISteamerRequest Request { get; set; }

        public ISteamerSerializerDataProvider Provider { get; set; }

        Option<object> ISteamerResponse.Model { get; set; }

        public Option<FriendsListModel> Model { get; set; }
    }
}