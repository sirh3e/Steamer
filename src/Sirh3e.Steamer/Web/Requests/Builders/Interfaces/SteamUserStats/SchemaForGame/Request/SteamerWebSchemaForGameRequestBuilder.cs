using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request
{
    public class SteamerWebSchemaForGameRequestBuilder
        : SteamerRequestBuilder<SteamerWebSchemaForGameRequestBuilder, ISteamerWebSchemaForGameRequest>,
            ISteamerWebSchemaForGameRequestBuilder
    {
        public SteamerWebSchemaForGameRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebSchemaForGameRequest(Interface ??
                                                         throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebSchemaForGameRequest Build()
        {
            var request = Request;

            Request = new SteamerWebSchemaForGameRequest(Interface ??
                                                         throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebSchemaForGameRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebSchemaForGameRequestBuilder SetAppId(uint appId)
            => SetValue("appid", appId);

        public ISteamerWebSchemaForGameRequestBuilder SetLanguage(string language)
            => SetValue("l", language ?? throw new ArgumentNullException(nameof(language)));
    }
}