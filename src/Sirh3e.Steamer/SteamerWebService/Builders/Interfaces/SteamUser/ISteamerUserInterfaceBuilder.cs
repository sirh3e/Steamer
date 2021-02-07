using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser
{
    public interface ISteamerUserInterfaceBuilder : ISteamerInterface
    {
        public IFriendListRequestBuilder FriendList { get; }
        public IPlayerBansRequestBuilder PlayerBans { get; }
        public IPlayerSummariesRequestBuilder PlayerSummaries { get; }
        public IResolveVanityUrlRequestBuilder ResolveVanityUrl { get; }
    }
}