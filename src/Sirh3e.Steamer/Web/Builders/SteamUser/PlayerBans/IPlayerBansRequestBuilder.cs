namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans
{
    public interface IPlayerBansRequestBuilder
    {
        public IPlayerBansRequestBuilder SetKey(string key);
        public IPlayerBansRequestBuilder SetSteamIds(params ulong[] steamIds);
        public IPlayerBansRequest Build();
    }
}