using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request
{
    public interface ISteamerWebResolveVanityUrlRequestBuilder : ISteamerRequestBuilder<ISteamerWebResolveVanityUrlRequest>
    {
        public ISteamerWebResolveVanityUrlRequestBuilder SetKey(string key);
        public ISteamerWebResolveVanityUrlRequestBuilder SetVanityUrl(string vanityUrl);
        public ISteamerWebResolveVanityUrlRequestBuilder SetUrlType(string urlType);
    }
}