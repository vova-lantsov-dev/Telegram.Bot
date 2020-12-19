namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents an animation file to be displayed in the message containing a <see cref="Game"/>.
    /// </summary>
    ////[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record Animation
    {
        /// <summary>
        /// Identifier for this file, which can be used to download or reuse the file
        /// </summary>
        ////[JsonProperty(Required = Required.Always)]
        public string FileId { get; init; }

        /// <summary>
        /// Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
        /// </summary>
        ////[JsonProperty(Required = Required.Always)]
        public string FileUniqueId { get; init; }

        /// <summary>
        /// Video width as defined by sender
        /// </summary>
        ////[JsonProperty(Required = Required.Always)]
        public int Width { get; init; }

        /// <summary>
        /// Video height as defined by sender
        /// </summary>
        ////[JsonProperty(Required = Required.Always)]
        public int Height { get; init; }

        /// <summary>
        /// Duration of the video in seconds as defined by sender
        /// </summary>
        ////[JsonProperty(Required = Required.Always)]
        public int Duration { get; init; }

        /// <summary>
        /// Animation thumbnail as defined by sender.
        /// </summary>
        ////[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; init; }

        /// <summary>
        /// Original animation filename as defined by sender.
        /// </summary>
        ////[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileName { get; init; }

        /// <summary>
        /// MIME type of the file as defined by sender.
        /// </summary>
        ////[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MimeType { get; init; }

        /// <summary>
        /// File size.
        /// </summary>
        ////[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int FileSize { get; init; }
    }
}
