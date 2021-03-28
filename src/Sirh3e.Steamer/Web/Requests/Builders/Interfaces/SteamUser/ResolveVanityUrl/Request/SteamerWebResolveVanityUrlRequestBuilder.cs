using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request
{
    public class SteamerWebResolveVanityUrlRequestBuilder :
        SteamerRequestBuilder<SteamerWebResolveVanityUrlRequestBuilder, ISteamerWebResolveVanityUrlRequest>,
        ISteamerWebResolveVanityUrlRequestBuilder
    {
        public SteamerWebResolveVanityUrlRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request =
                new SteamerWebResolveVanityUrlRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));
        }

        public override ISteamerWebResolveVanityUrlRequest Build()
        {
            var request = Request;

            Request = new SteamerWebResolveVanityUrlRequest(Interface ??
                                                            throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebResolveVanityUrlRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebResolveVanityUrlRequestBuilder SetVanityUrl(string vanityUrl)
            => SetValue("vanityurl", vanityUrl ?? throw new ArgumentNullException(nameof(vanityUrl)));

        public ISteamerWebResolveVanityUrlRequestBuilder SetUrlType(string urlType)
            => SetValue("url_type", urlType ?? throw new ArgumentNullException(nameof(urlType)));
    }
}