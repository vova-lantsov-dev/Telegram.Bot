namespace Telegram.Bot.Types.Payments
{
    /// <summary>
    /// This object represents one shipping option.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record ShippingOption
    {
        /// <summary>
        /// Shipping option identifier
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Id { get; init; }

        /// <summary>
        /// Option title
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Title { get; init; }

        /// <summary>
        /// List of price portions
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public LabeledPrice[] Prices { get; set; }
    }
}
