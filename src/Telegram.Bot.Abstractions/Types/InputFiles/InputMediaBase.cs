﻿using Telegram.Bot.Types.Enums;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents the content of a media message to be sent
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract record InputMediaBase : IInputMedia
    {
        /// <summary>
        /// Type of the media
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Type { get; protected set; }

        /// <summary>
        /// Media to send
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public InputMedia Media { get; init; } // ToDo Should be get-only. Media is set in ctors

        /// <summary>
        /// Optional. Caption of the photo to be sent, 0-1024 characters
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; init; }

        /// <summary>
        /// Change, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in a caption
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ParseMode ParseMode { get; init; }
    }
}
