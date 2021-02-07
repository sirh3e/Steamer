namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerSummaries.Request
{
    /*
    public class PlayerSummariesRequestRequestBuilder : IPlayerSummariesRequestRequestBuilder
    {
        public PlayerSummariesRequestRequestBuilder(ISteamerInterface @interface)
        {
            Interface = @interface ?? throw new ArgumentNullException(nameof(@interface));
            Method = GetDefaultMethod();
        }

        public ISteamerInterface Interface { get; }
        public ISteamerMethod Method { get; private set; }

        public ISteamerMethod GetDefaultMethod()
        {
            return new SteamerMethod(Interface,
                HttpMethod.Get, "GetPlayerSummaries", 2,
                new SteamerParameters(
                    new SteamerStringParameter("key"),
                    new SteamerStringParameter("steamids")));
        }

        public IPlayerSummariesRequestRequestBuilder SetKey(string key)
        {
            _ = key ?? throw new ArgumentNullException(nameof(key));

            Method.Parameters.SetValue("key", key);

            return this;
        }

        public IPlayerSummariesRequestRequestBuilder SetSteamIds(params ulong[] steamIds)
        {
            _ = steamIds ?? throw new ArgumentNullException(nameof(steamIds));

            var value = string.Join(",", steamIds.Select(steamId => steamId.ToString()).ToList());

            Method.Parameters.SetValue("steamids", value);

            return this;
        }

        public IPlayerSummariesRequest Build()
        {
            var request = new PlayerSummariesRequest { Method = Method };

            Method = GetDefaultMethod();
            return request;
        }
    }
    */
}