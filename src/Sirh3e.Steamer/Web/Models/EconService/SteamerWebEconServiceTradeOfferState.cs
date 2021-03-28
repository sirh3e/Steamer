namespace Sirh3e.Steamer.Web.Models.EconService
{
    //https://developer.valvesoftware.com/wiki/Steam_Web_API/IEconService#ETradeOfferState
    public enum SteamerWebEconServiceTradeOfferState
    {
        /// <summary>
        ///     Invalid
        /// </summary>
        Invalid = 1,

        /// <summary>
        ///     This trade offer has been sent, neither party has acted on it yet.
        /// </summary>
        Active = 2,

        /// <summary>
        ///     The trade offer was accepted by the recipient and items were exchanged.
        /// </summary>
        Accepted = 3,

        /// <summary>
        ///     The recipient made a counter offer
        /// </summary>
        Countered = 4,

        /// <summary>
        ///     The trade offer was not accepted before the expiration date
        /// </summary>
        Expired = 5,

        /// <summary>
        ///     The sender cancelled the offer
        /// </summary>
        Canceled = 6,

        /// <summary>
        ///     The recipient declined the offer
        /// </summary>
        Declined = 7,

        /// <summary>
        ///     Some of the items in the offer are no longer available (indicated by the missing flag in the output)
        /// </summary>
        InvalidItems = 8,

        /// <summary>
        ///     The offer hasn't been sent yet and is awaiting email/mobile confirmation. The offer is only visible to the sender.
        /// </summary>
        CreatedNeedsConfirmation = 9,

        /// <summary>
        ///     Either party canceled the offer via email/mobile. The offer is visible to both parties, even if the sender canceled
        ///     it before it was sent.
        /// </summary>
        CanceledBySecondFactor = 10,

        /// <summary>
        ///     The trade has been placed on hold. The items involved in the trade have all been removed from both parties'
        ///     inventories and will be automatically delivered in the future.
        /// </summary>
        InEscrow = 11
    }
}