using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request
{
    public class ResolveVanityUrlRequestBuilder : SteamerRequestBuilder<ResolveVanityUrlRequestBuilder, IResolveVanityUrlRequest>, IResolveVanityUrlRequestBuilder
    {
        public ResolveVanityUrlRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new ResolveVanityUrlRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));
        }

        public override IResolveVanityUrlRequest Build()
        {
            var request = Request;

            Request = new ResolveVanityUrlRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public IResolveVanityUrlRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public IResolveVanityUrlRequestBuilder SetVanityUrl(string vanityUrl)
            => SetValue("vanityurl", vanityUrl ?? throw new ArgumentNullException(nameof(vanityUrl)));

        public IResolveVanityUrlRequestBuilder SetUrlType(string urlType)
            => SetValue("url_type", urlType ?? throw new ArgumentNullException(nameof(urlType)));
    }
}