using Sirh3e.Steamer.Web.Services.EconService.Binders;

namespace Sirh3e.Steamer.Web.Services.EconService
{
    public interface ISteamerWebServiceEconServiceServicesBinders :
        ISteamerWebServiceCancelTradeOfferBinder,
        ISteamerWebServiceDeclineTradeOfferBinder,
        ISteamerWebServiceTradeHistoryBinder,
        ISteamerWebServiceTradeOfferBinder,
        ISteamerWebServiceTradeOffersBinder,
        ISteamerWebServiceTradeOffersSummaryBinder
    {
    }
}