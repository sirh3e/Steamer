using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request
{
    public class SteamerWebSchemaForGameBuilder
        : SteamerRequestBuilder<SteamerWebSchemaForGameBuilder, ISteamerWebSchemaForGameRequest>,
            ISteamerWebSchemaForGameBuilder
    {
        public SteamerWebSchemaForGameBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebSchemaForGameRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebSchemaForGameRequest Build()
        {
            var request = Request;

            Request = new SteamerWebSchemaForGameRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebSchemaForGameBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebSchemaForGameBuilder SetAppId(uint appId)
            => SetValue("appid", appId);

        public ISteamerWebSchemaForGameBuilder SetLanguage(string language)
            => SetValue("l", language ?? throw new ArgumentNullException(nameof(language)));
    }
}