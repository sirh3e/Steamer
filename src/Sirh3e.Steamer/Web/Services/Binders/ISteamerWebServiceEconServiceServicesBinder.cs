using Sirh3e.Steamer.Web.Services.Binders.EconService;

namespace Sirh3e.Steamer.Web.Services.Binders
{
    public interface ISteamerWebServiceEconServiceServicesBinder :
            ISteamerWebServiceCancelTradeOfferBinder,
        ISteamerWebServiceDeclineTradeOfferBinder,
        ISteamerWebServiceTradeHistoryBinder,
        ISteamerWebServiceTradeOfferBinder,
        ISteamerWebServiceTradeOffersBinder,
        ISteamerWebServiceTradeOffersSummaryBinder
    {
    }
}