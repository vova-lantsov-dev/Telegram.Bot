namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a sticker.
    /// <see href="https://core.telegram.org/bots/api#sticker"/>
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record Sticker : FileBase
    {
        /// <summary>
        /// Sticker width
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Width { get; init; }

        /// <summary>
        /// Sticker height
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Height { get; init; }

        /// <summary>
        /// True, if the sticker is animated
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public bool IsAnimated { get; init; }

        /// <summary>
        /// Sticker thumbnail in .webp or .jpg format
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; init; }

        /// <summary>
        /// Emoji associated with the sticker
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emoji { get; init; }

        /// <summary>
        /// Optional. Name of the sticker set to which the sticker belongs
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SetName { get; init; }

        /// <summary>
        /// Optional. For mask stickers, the position where the mask should be placed
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MaskPosition MaskPosition { get; init; }
    }
}
