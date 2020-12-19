﻿namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a voice note.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record Voice : FileBase
    {
        /// <summary>
        /// Duration of the audio in seconds as defined by sender
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Duration { get; init; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MimeType { get; init; }
    }
}
