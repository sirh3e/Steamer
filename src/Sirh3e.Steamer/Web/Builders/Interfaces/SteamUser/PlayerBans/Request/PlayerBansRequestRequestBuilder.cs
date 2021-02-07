namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    /*
    public class PlayerBansRequestRequestBuilder : IPlayerBansRequestRequestBuilder //ToDo rename SteamerMethod
    {
        public PlayerBansRequestRequestBuilder(ISteamerInterface @interface)
        {
            Interface = @interface;
            Method = GetDefaultMethod();
        }

        public ISteamerMethod GetDefaultMethod()
        {
            return new SteamerMethod(Interface,
                HttpMethod.Get, "GetPlayerBans", 1,
                new SteamerParameters(
                    new SteamerStringParameter("key"),
                    new SteamerStringParameter("steamids")));
        }

        public IPlayerBansRequestRequestBuilder SetKey(string key)
        {
            _ = key ?? throw new ArgumentNullException(nameof(key));

            Method.Parameters.SetValue("key", key);

            return this;
        }

        public IPlayerBansRequestRequestBuilder SetSteamIds(params ulong[] steamIds)
        {
            _ = steamIds ?? throw new ArgumentNullException(nameof(steamIds));

            var value = string.Join(",", steamIds.Select(steamId => steamId.ToString()).ToList());

            Method.Parameters.SetValue("steamids", value);

            return this;
        }

        public IPlayerBansRequest Request { get; }

        public IPlayerBansRequest Build()
        {
            var request = new PlayerBansRequest { Method = Method };

            Method = GetDefaultMethod();
            return request;
        }
    }
    */
}