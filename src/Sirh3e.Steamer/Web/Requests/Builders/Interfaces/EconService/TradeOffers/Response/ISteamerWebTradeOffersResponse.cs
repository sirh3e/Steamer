﻿using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Web.Models;
using Sirh3e.Steamer.Web.Models.EconService.TradeOffers;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService.TradeOffers.Response
{
    public interface ISteamerWebTradeOffersResponse : ISteamerResponse<ISteamerWebTradeOffersRequest,
        SteamerWebResponseModel<SteamerWebTradeOffersModel>>
    {
    }
}