using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults.Abstractions;

namespace Telegram.Bot.Types.InlineQueryResults
{
    /// <summary>
    /// Represents a link to a photo.
    /// By default, this photo will be sent by the user with optional caption.
    /// Alternatively, you can provide message_text to send it instead of photo.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record InlineQueryResultPhoto : InlineQueryResultBase,
        ICaptionInlineQueryResult,
        IThumbnailUrlInlineQueryResult,
        ITitleInlineQueryResult,
        IInputMessageContentResult
    {
        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public string ThumbUrl { get; init; }

        /// <summary>
        /// A valid URL of the photo. Photo size must not exceed 5MB.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string PhotoUrl { get; init; }

        /// <summary>
        /// Optional. Width of the photo
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PhotoWidth { get; init; }

        /// <summary>
        /// Optional. Height of the photo
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PhotoHeight { get; init; }

        /// <summary>
        /// Optional. Short description of the result
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ParseMode ParseMode { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContentBase InputMessageContent { get; init; }

        private InlineQueryResultPhoto()
            : base(InlineQueryResultType.Photo)
        {
        }

        /// <summary>
        /// Initializes a new inline query representing a link to a photo
        /// </summary>
        /// <param name="id">Unique identifier of this result</param>
        /// <param name="photoUrl">A valid URL of the photo. Photo size must not exceed 5MB.</param>
        /// <param name="thumbUrl">Optional. Url of the thumbnail for the result.</param>
        public InlineQueryResultPhoto(string id, string photoUrl, string thumbUrl)
            : base(InlineQueryResultType.Photo, id)
        {
            PhotoUrl = photoUrl;
            ThumbUrl = thumbUrl;
        }
    }
}
