namespace Sirh3e.Steamer.Web.Models.EconService
{
    public enum SteamerWebEconServiceTradeOfferConfirmationMethod
    {
        /// <summary>
        ///     Invalid
        /// </summary>
        Invalid = 0,

        /// <summary>
        ///     An email was sent with details on how to confirm the trade offer
        /// </summary>
        Email = 1,

        /// <summary>
        ///     The trade offer may be confirmed via the mobile app
        /// </summary>
        Mobile = 2
    }
}