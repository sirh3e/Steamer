using Sirh3e.Steamer.Core.Method;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans {
    public class PlayerBansRequest : IPlayerBansRequest {
        public ISteamerMethod Method { get; set; }
    }
}