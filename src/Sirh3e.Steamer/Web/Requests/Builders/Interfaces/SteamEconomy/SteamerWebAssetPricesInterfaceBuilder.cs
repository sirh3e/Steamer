using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamEconomy.AssetPrices.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamEconomy
{
    public class SteamerWebAssetPricesInterfaceBuilder : SteamerInterface, ISteamerWebAssetPricesInterfaceBuilder
    {
        public SteamerWebAssetPricesInterfaceBuilder() : base("ISteamEconomy")
        {
            AssetPrices = new SteamerWebAssetPricesRequestBuilder(this);
        }

        public ISteamerWebAssetPricesRequestBuilder AssetPrices { get; }
    }
}