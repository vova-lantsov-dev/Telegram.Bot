namespace Telegram.Bot.Types.Payments
{
    /// <summary>
    /// This object contains information about an incoming shipping query.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record ShippingQuery
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
        /// Bot specified invoice payload
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string InvoicePayload { get; init; }

        /// <summary>
        /// User specified shipping address
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public ShippingAddress ShippingAddress { get; init; }
    }
}
