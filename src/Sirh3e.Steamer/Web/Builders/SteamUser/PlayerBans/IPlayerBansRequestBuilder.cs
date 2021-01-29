namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans
{
    public interface IPlayerBansRequestBuilder
    {
        public IPlayerBansRequestBuilder SetSteamIds(params ulong[] steamids);
        public IPlayerBansRequest Build();
    }
}