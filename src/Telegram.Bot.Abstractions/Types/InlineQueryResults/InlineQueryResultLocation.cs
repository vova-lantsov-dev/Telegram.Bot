using Telegram.Bot.Types.InlineQueryResults.Abstractions;

namespace Telegram.Bot.Types.InlineQueryResults
{
    /// <summary>
    /// Represents a location on a map. By default, the location will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the location.
    /// </summary>
    /// <remarks>
    /// This will only work in Telegram versions released after 9 April, 2016. Older clients will ignore them.
    /// </remarks>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record InlineQueryResultLocation : InlineQueryResultBase,
        IThumbnailInlineQueryResult,
        ITitleInlineQueryResult,
        IInputMessageContentResult,
        ILocationInlineQueryResult
    {
        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public float Latitude { get; init; }

        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public float Longitude { get; init; }

        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public string Title { get; init; }

        /// <summary>
        /// Period in seconds for which the location can be updated, should be between 60 and 86400.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int LivePeriod { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThumbUrl { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ThumbWidth { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ThumbHeight { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContentBase InputMessageContent { get; init; }

        private InlineQueryResultLocation()
            : base(InlineQueryResultType.Location)
        {
        }

        /// <summary>
        /// Initializes a new inline query result
        /// </summary>
        /// <param name="id">Unique identifier of this result</param>
        /// <param name="latitude">Latitude of the location in degrees</param>
        /// <param name="longitude">Longitude of the location in degrees</param>
        /// <param name="title">Title of the result</param>
        public InlineQueryResultLocation(string id, float latitude, float longitude, string title)
            : base(InlineQueryResultType.Location, id)
        {
            Latitude = latitude;
            Longitude = longitude;
            Title = title;
        }
    }
}
