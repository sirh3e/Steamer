using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats.SchemaForGame.Request
{
    public interface ISteamerWebSchemaForGameBuilder : ISteamerRequestBuilder<ISteamerWebSchemaForGameRequest>
    {
        public ISteamerWebSchemaForGameBuilder SetKey(string key);
        public ISteamerWebSchemaForGameBuilder SetAppId(uint appId);
        public ISteamerWebSchemaForGameBuilder SetLanguage(string language);
    }
}