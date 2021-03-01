using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.SteamLevel.Request
{
    public class SteamerWebSteamLevelRequestBuilder
        : SteamerRequestBuilder<SteamerWebSteamLevelRequestBuilder, ISteamerWebSteamLevelRequest>,
            ISteamerWebSteamLevelRequestBuilder
    {
        public SteamerWebSteamLevelRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebSteamLevelRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebSteamLevelRequest Build()
        {
            var request = Request;

            Request = new SteamerWebSteamLevelRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebSteamLevelRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebSteamLevelRequestBuilder SetSteamId(ulong steamId)
            => SetValue("steamid", steamId);
    }
}