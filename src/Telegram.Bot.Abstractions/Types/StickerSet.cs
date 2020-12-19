﻿namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a sticker set.
    /// <see href="https://core.telegram.org/bots/api#stickerset"/>
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record StickerSet
    {
        /// <summary>
        /// Sticker set name
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Name { get; init; }

        /// <summary>
        /// Sticker set title
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Title { get; init; }

        /// <summary>
        /// True, if the sticker set contains animated stickers
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public bool IsAnimated { get; init; }

        /// <summary>
        /// True, if the sticker set contains masks
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public bool ContainsMasks { get; init; }

        /// <summary>
        /// List of all set stickers
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public Sticker[] Stickers { get; set; }

        /// <summary>
        /// Optional. Sticker set thumbnail in the .WEBP or .TGS format
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; init; }
    }
}
