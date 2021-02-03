using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans {
    public interface IPlayerBansRequestBuilder : ISteamerBuilder<IPlayerBansRequest> {
        public IPlayerBansRequestBuilder SetKey(string key);
        public IPlayerBansRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}