using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    public interface IPlayerBansRequestRequestBuilder : ISteamerRequestBuilder<IPlayerBansRequest>
    {
        public IPlayerBansRequestRequestBuilder SetKey(string key);
        public IPlayerBansRequestRequestBuilder SetSteamIds(params ulong[] steamIds);
    }
}