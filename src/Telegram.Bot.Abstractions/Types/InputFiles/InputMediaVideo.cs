using System;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Types
{
    /// <summary>
    /// Represents a video to be sent
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record InputMediaVideo : InputMediaBase, IInputMediaThumb, IAlbumInputMedia
    {
        /// <summary>
        /// Optional. Video width
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Width { get; init; }

        /// <summary>
        /// Optional. Video height
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Height { get; init; }

        /// <summary>
        /// Optional. Video duration
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Duration { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMedia Thumb { get; init; }

        /// <summary>
        /// Optional. Pass True, if the uploaded video is suitable for streaming
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SupportsStreaming { get; init; }

        /// <summary>
        /// Initializes a new video media to send
        /// </summary>
        [Obsolete("Use the other overload of this constructor with required parameter instead.")]
        public InputMediaVideo()
        {
            Type = "video";
        }

        /// <summary>
        /// Initializes a new video media to send with an <see cref="InputMedia"/>
        /// </summary>
        public InputMediaVideo(InputMedia media)
        {
            Type = "video";
            Media = media;
        }
    }
}
