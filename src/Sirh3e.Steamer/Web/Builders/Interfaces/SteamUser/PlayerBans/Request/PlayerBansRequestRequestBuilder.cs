using System;
using System.Linq;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    public class PlayerBansRequestRequestBuilder : SteamerRequestBuilder<PlayerBansRequestRequestBuilder, IPlayerBansRequest>, IPlayerBansRequestRequestBuilder //ToDo rename SteamerMethod
    {
        public PlayerBansRequestRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new PlayerBansRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));
        }

        public IPlayerBansRequestRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        //ToDo change parameter to / create a parameter for list
        public IPlayerBansRequestRequestBuilder SetSteamIds(params ulong[] steamIds)
            => SetValue("key", string.Join(",", steamIds.Select(steamId => steamId.ToString()).ToList() ?? throw new ArgumentNullException(nameof(steamIds))));

        public override IPlayerBansRequest Build()
        {
            var request = Request;

            Request = new PlayerBansRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

            return request;
        }
    }
}