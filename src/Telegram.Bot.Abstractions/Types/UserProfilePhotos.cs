namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represent a user's profile pictures.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record UserProfilePhotos
    {
        /// <summary>
        /// Total number of profile pictures the target user has
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int TotalCount { get; init; }

        /// <summary>
        /// Requested profile pictures (in up to 4 sizes each)
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public PhotoSize[][] Photos { get; set; }
    }
}
