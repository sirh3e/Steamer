using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    public interface IPlayerBansRequestBuilder : ISteamerRequestBuilder<IPlayerBansRequest>
    {
        public IPlayerBansRequestBuilder SetKey(string key);
        public IPlayerBansRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}