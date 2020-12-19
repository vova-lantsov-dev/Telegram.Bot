namespace Telegram.Bot.Types.Payments
{
    /// <summary>
    /// This object represents a shipping address.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record ShippingAddress
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string CountryCode { get; init; }

        /// <summary>
        /// State, if applicable
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; init; }

        /// <summary>
        /// City
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string City { get; init; }

        /// <summary>
        /// First line for the address
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string StreetLine1 { get; set; }

        /// <summary>
        /// Second line for the address
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string StreetLine2 { get; set; }

        /// <summary>
        /// Address post code
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string PostCode { get; init; }
    }
}
