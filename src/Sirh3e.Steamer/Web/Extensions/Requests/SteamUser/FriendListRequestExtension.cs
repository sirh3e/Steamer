using System;

using Sirh3e.Steamer.Web.Builders.SteamUser.FriendList;
using Sirh3e.Steamer.Web.Services.Web;

namespace Sirh3e.Steamer.Web.Extensions.Requests.SteamUser {
    public static class FriendListRequestExtension {
        public static IFriendListResponse ServiceExecute(this IFriendListRequest request,
            ISteamerWebService service) {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}