﻿using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffersSummary.Response;

namespace Sirh3e.Steamer.Web.Services.Binders.EconService
{
    public interface ISteamerWebServiceTradeOffersSummaryBinder
        : ISteamerServiceBinder<ISteamerWebTradeOffersSummaryRequest, ISteamerWebTradeOffersSummaryResponse>
    {
    }
}