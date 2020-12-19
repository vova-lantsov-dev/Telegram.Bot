﻿namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a video file.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record Video : FileBase
    {
        /// <summary>
        /// Video width as defined by sender
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Width { get; init; }

        /// <summary>
        /// Video height as defined by sender
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Height { get; init; }

        /// <summary>
        /// Duration of the video in seconds as defined by sender
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Duration { get; init; }

        /// <summary>
        /// Video thumbnail
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; init; }

        /// <summary>
        /// Optional. Mime type of a file as defined by sender
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MimeType { get; init; }
    }
}
