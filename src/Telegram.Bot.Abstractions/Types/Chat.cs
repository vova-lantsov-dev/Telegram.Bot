﻿using System;
using System.Text.Json.Serialization;
using Telegram.Bot.Converters;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a chat.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record Chat : IAutoGeneratedChat
    {
        /// <summary>
        /// Unique identifier for this chat, not exceeding 1e13 by absolute value
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public long Id { get; init; }

        /// <summary>
        /// Type of chat
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        [JsonConverter(typeof(JsonStringSnakeCaseEnumConverter))]
        public ChatType Type { get; init; }

        /// <summary>
        /// Optional. Title, for channels and group chats
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; init; }

        /// <summary>
        /// Optional. Username, for private chats and channels if available
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; init; }

        /// <summary>
        /// Optional. First name of the other party in a private chat
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; init; }

        /// <summary>
        /// Optional. Last name of the other party in a private chat
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; init; }

        /// <summary>
        /// Optional. True if a group has 'All Members Are Admins' enabled.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Obsolete("Use Permissions field instead")]
        public bool AllMembersAreAdministrators { get; init; }

        /// <summary>
        /// Optional. Chat photo. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPhoto Photo { get; init; }

        /// <summary>
        /// Optional. Description, for supergroups and channel chats. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; init; }

        /// <summary>
        /// Optional. Chat invite link, for supergroups and channel chats. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InviteLink { get; init; }

        /// <summary>
        /// Optional. Pinned message, for supergroups. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message PinnedMessage { get; init; }

        /// <summary>
        /// Optional. Pinned message, for groups, supergroups and channels. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPermissions Permissions { get; init; }

        /// <summary>
        /// Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unpriviledged user. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? SlowModeDelay { get; init; }

        /// <summary>
        /// Optional. For supergroups, name of group sticker set. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StickerSetName { get; init; }

        /// <summary>
        /// Optional. True, if the bot can change the group sticker set. Returned only in getChat.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSetStickerSet { get; init; }
    }
}
