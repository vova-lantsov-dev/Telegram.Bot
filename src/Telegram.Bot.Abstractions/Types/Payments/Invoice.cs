namespace Telegram.Bot.Types.Payments
{
    /// <summary>
    /// This object contains basic information about an invoice.
    /// </summary>
    /// <seealso href="https://core.telegram.org/bots/api#invoice"/>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record Invoice
    {
        /// <summary>
        /// Product name
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Title { get; init; }

        /// <summary>
        /// Product description
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Description { get; init; }

        /// <summary>
        /// Unique bot deep-linking parameter that can be used to generate this invoice
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string StartParameter { get; init; }

        /// <summary>
        /// Three-letter ISO 4217 currency code
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Currency { get; init; }

        /// <summary>
        /// Total price in the smallest units of the currency.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int TotalAmount { get; init; }
    }
}
