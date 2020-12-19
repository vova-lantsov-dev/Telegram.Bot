namespace Telegram.Bot.Types
{
    /// <summary>
    /// Collection of fileIds of profile pictures of a chat.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record ChatPhoto
    {
        /// <summary>
        /// File id of the big version of this <see cref="ChatPhoto"/>
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string BigFileId { get; init; }

        /// <summary>
        /// Unique file identifier of big (640x640) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string BigFileUniqueId { get; init; }

        /// <summary>
        /// File id of the small version of this <see cref="ChatPhoto"/>
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string SmallFileId { get; init; }

        /// <summary>
        /// Unique file identifier of small (160x160) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string SmallFileUniqueId { get; init; }
    }
}
