﻿using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.DeclineTradeOffer.Response;

namespace Sirh3e.Steamer.Web.Services.Binders.EconService
{
    public interface ISteamerWebServiceDeclineTradeOfferBinder
        : ISteamerServiceBinder<ISteamerWebDeclineTradeOfferRequest, ISteamerWebDeclineTradeOfferResponse>
    {

    }
}