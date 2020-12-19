namespace Telegram.Bot.Types.Payments
{
    /// <summary>
    /// This object contains information about an incoming pre-checkout query
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record PreCheckoutQuery
    {
        /// <summary>
        /// Unique query identifier
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Id { get; init; }

        /// <summary>
        /// User who sent the query
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public User From { get; init; }

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

        /// <summary>
        /// Bot specified invoice payload
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string InvoicePayload { get; init; }

        /// <summary>
        /// Optional. Identifier of the shipping option chosen by the user
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ShippingOptionId { get; init; }

        /// <summary>
        /// Optional. Order info provided by the user
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrderInfo OrderInfo { get; init; }
    }
}
