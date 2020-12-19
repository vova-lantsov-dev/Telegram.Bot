﻿namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents an audio file to be treated as music by the Telegram clients.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record Audio : FileBase
    {
        /// <summary>
        /// Duration of the audio in seconds as defined by sender
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Duration { get; init; }

        /// <summary>
        /// Optional. Performer of the audio as defined by sender or by audio tags
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Performer { get; init; }

        /// <summary>
        /// Optional. Title of the audio as defined by sender or by audio tags
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; init; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MimeType { get; init; }

        /// <summary>
        /// Optional. Thumbnail of the album cover to which the music file belongs
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; init; }
    }
}
