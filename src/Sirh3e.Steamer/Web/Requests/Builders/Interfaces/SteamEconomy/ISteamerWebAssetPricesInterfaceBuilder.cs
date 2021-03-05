using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamEconomy.AssetPrices.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamEconomy
{
    public interface ISteamerWebAssetPricesInterfaceBuilder
    {
        public ISteamerWebAssetPricesRequestBuilder AssetPrices { get; }
    }
}