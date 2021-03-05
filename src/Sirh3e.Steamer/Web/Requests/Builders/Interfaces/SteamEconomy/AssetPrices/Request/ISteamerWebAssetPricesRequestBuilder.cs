using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamEconomy.AssetPrices.Request
{
    public interface ISteamerWebAssetPricesRequestBuilder : ISteamerRequestBuilder<ISteamerWebAssetPricesRequest>
    {
        public ISteamerWebAssetPricesRequestBuilder SetKey(string key);
        public ISteamerWebAssetPricesRequestBuilder SetAppId(uint appId);
        public ISteamerWebAssetPricesRequestBuilder SetCurrency(string currency);
        public ISteamerWebAssetPricesRequestBuilder SetLanguage(string language);
    }
}