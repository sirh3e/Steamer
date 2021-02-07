using System;
using System.Linq;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerSummaries.Request
{
    public class PlayerSummariesRequestBuilder : SteamerRequestBuilder<PlayerSummariesRequestBuilder, IPlayerSummariesRequest>, IPlayerSummariesRequestBuilder
    {
        public PlayerSummariesRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new PlayerSummariesRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));
        }

        public IPlayerSummariesRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        //ToDo change parameter to / create a parameter for list
        public IPlayerSummariesRequestBuilder SetSteamIds(params ulong[] steamIds)
            => SetValue("steamids", string.Join(",", steamIds.Select(steamId => steamId.ToString()).ToList() ?? throw new ArgumentNullException(nameof(steamIds))));

        public override IPlayerSummariesRequest Build()
        {
            var request = Request;

            Request = new PlayerSummariesRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

            return request;
        }
    }
}