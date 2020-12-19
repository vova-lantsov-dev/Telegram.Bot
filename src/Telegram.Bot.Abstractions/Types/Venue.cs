namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a venue.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record Venue
    {
        /// <summary>
        /// Venue location
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public Location Location { get; init; }

        /// <summary>
        /// Title of the result
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Title { get; init; }

        /// <summary>
        /// Address of the venue
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Address { get; init; }

        /// <summary>
        /// Optional. Foursquare identifier of the venue
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareId { get; init; }

        /// <summary>
        /// Optional. Foursquare type of the venue. (For example, "arts_entertainment/default",
        /// "arts_entertainment/aquarium" or "food/icecream".)
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareType { get; init; }
    }
}
