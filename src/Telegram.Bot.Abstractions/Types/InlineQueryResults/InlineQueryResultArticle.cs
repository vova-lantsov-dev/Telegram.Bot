using Telegram.Bot.Types.InlineQueryResults.Abstractions;

namespace Telegram.Bot.Types.InlineQueryResults
{
    /// <summary>
    /// Represents a link to an article or web page.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record InlineQueryResultArticle : InlineQueryResultBase,
        IThumbnailInlineQueryResult,
        ITitleInlineQueryResult,
        IInputMessageContentResult
    {
        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public string Title { get; init; }

        /// <inheritdoc />
        //[JsonProperty(Required = Required.Always)]
        public InputMessageContentBase InputMessageContent { get; init; }

        /// <summary>
        /// Optional. URL of the result.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; init; }

        /// <summary>
        /// Optional. Pass <c>true</c>, if you don't want the URL to be shown in the message.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HideUrl { get; init; }

        /// <summary>
        /// Optional. Short description of the result.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThumbUrl { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ThumbWidth { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ThumbHeight { get; init; }

        private InlineQueryResultArticle()
            : base(InlineQueryResultType.Article)
        {
        }

        /// <summary>
        /// Initializes a new inline query result
        /// </summary>
        /// <param name="id">Unique identifier of this result</param>
        /// <param name="title">Title of the result</param>
        /// <param name="inputMessageContent">Content of the message to be sent</param>
        public InlineQueryResultArticle(string id, string title, InputMessageContentBase inputMessageContent)
            : base(InlineQueryResultType.Article, id)
        {
            Title = title;
            InputMessageContent = inputMessageContent;
        }
    }
}
