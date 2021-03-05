using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamEconomy.AssetPrices.Request
{
    public class SteamerWebAssetPricesRequestBuilder :
        SteamerRequestBuilder<SteamerWebAssetPricesRequestBuilder, ISteamerWebAssetPricesRequest>,
        ISteamerWebAssetPricesRequestBuilder
    {
        public SteamerWebAssetPricesRequestBuilder(ISteamerInterface @interface) : base(@interface)
        {
            Request = new SteamerWebAssetPricesRequest(Interface ??
                                                       throw new ArgumentNullException(nameof(Interface)));
        }

        public override ISteamerWebAssetPricesRequest Build()
        {
            var request = Request;

            Request = new SteamerWebAssetPricesRequest(Interface ??
                                                       throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebAssetPricesRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        public ISteamerWebAssetPricesRequestBuilder SetAppId(uint appId)
            => SetValue("appid", appId);

        public ISteamerWebAssetPricesRequestBuilder SetCurrency(string currency)
            => SetValue("currency", currency ?? throw new ArgumentNullException(nameof(currency)));

        public ISteamerWebAssetPricesRequestBuilder SetLanguage(string language)
            => SetValue("language", language ?? throw new ArgumentNullException(nameof(language)));
    }
}