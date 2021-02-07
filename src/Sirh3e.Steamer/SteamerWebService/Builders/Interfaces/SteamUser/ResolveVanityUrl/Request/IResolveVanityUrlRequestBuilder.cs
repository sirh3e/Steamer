using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request
{
    public interface IResolveVanityUrlRequestBuilder : ISteamerRequestBuilder<IResolveVanityUrlRequest>
    {
        public IResolveVanityUrlRequestBuilder SetKey(string key);
        public IResolveVanityUrlRequestBuilder SetVanityUrl(string vanityUrl);
        public IResolveVanityUrlRequestBuilder SetUrlType(string urlType);
    }
}