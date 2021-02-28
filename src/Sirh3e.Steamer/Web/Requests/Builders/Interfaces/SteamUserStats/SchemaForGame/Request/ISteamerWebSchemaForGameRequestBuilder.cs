using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request
{
    public interface ISteamerWebSchemaForGameRequestBuilder : ISteamerRequestBuilder<ISteamerWebSchemaForGameRequest>
    {
        public ISteamerWebSchemaForGameRequestBuilder SetKey(string key);
        public ISteamerWebSchemaForGameRequestBuilder SetAppId(uint appId);
        public ISteamerWebSchemaForGameRequestBuilder SetLanguage(string language);
    }
}