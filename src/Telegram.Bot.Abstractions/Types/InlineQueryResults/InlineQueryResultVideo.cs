using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults.Abstractions;

namespace Telegram.Bot.Types.InlineQueryResults
{
    /// <summary>
    /// Represents link to a page containing an embedded video player or a video file.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record InlineQueryResultVideo : InlineQueryResultBase,
        ICaptionInlineQueryResult,
        IThumbnailUrlInlineQueryResult,
        ITitleInlineQueryResult,
        IInputMessageContentResult
    {
        /// <summary>
        /// A valid URL for the embedded video player or video file
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string VideoUrl { get; init; }

        /// <summary>
        /// Mime type of the content of video url, i.e. "text/html" or "video/mp4"
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string MimeType { get; init; }

        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public string ThumbUrl { get; init; }

        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public string Title { get; init; }

        /// <summary>
        /// Optional. Video width
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int VideoWidth { get; init; }

        /// <summary>
        /// Optional. Video height
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int VideoHeight { get; init; }

        /// <summary>
        /// Optional. Video duration in seconds
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int VideoDuration { get; init; }

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
        public InputMessageContentBase InputMessageContent { get; init; }

        private InlineQueryResultVideo()
            : base(InlineQueryResultType.Video)
        {
        }

        /// <summary>
        /// Initializes a new inline query result
        /// </summary>
        /// <param name="id">Unique identifier of this result</param>
        /// <param name="videoUrl">A valid URL for the embedded video player or video file</param>
        /// <param name="mimeType">Mime type of the content of video url, i.e. "text/html" or "video/mp4"</param>
        /// <param name="thumbUrl">Url of the thumbnail for the result</param>
        /// <param name="title">Title of the result</param>
        public InlineQueryResultVideo(
            string id,
            string videoUrl,
            string mimeType,
            string thumbUrl,
            string title
        )
            : base(InlineQueryResultType.Video, id)
        {
            VideoUrl = videoUrl;
            MimeType = mimeType;
            ThumbUrl = thumbUrl;
            Title = title;
        }
    }
}
