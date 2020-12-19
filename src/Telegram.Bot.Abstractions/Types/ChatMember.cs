using System;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object contains information about one member of the chat.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record ChatMember
    {
        /// <summary>
        /// Information about the user
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public User User { get; init; }

        /// <summary>
        /// The member's status in the chat.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public ChatMemberStatus Status { get; init; }

        /// <summary>
        /// Optional. Owner and administrators only. Custom title for this user
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CustomTitle { get; init; }

        /// <summary>
        /// Optional. Restricted and kicked only. Date when restrictions will be lifted for this user, UTC time
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        //[JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UntilDate { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the bot is allowed to edit administrator privileges of that user
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanBeEdited { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can change the chat title, photo and other settings
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanChangeInfo { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can post in the channel, channels only
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPostMessages { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can edit messages of other users, channels only
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanEditMessages { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can delete messages of other users
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanDeleteMessages { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can invite new users to the chat
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanInviteUsers { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can restrict, ban or unban chat members
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanRestrictMembers { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can pin messages, supergroups only
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPinMessages { get; init; }

        /// <summary>
        /// Optional. Administrators only. True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by the user)
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanPromoteMembers { get; init; }

        /// <summary>
        /// Optional. Restricted only. True, if the user is a member of the chat at the moment of the request
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsMember { get; init; }

        /// <summary>
        /// Optional. Restricted only. True, if the user can send text messages, contacts, locations and venues
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendMessages { get; init; }

        /// <summary>
        /// Optional. Restricted only. True, if the user can send audios, documents, photos, videos, video notes and voice notes, implies <see cref="CanSendMessages"/>
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendMediaMessages { get; init; }

        /// <summary>
        /// Optional. Restricted only. True, if the user is allowed to send polls
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendPolls { get; init; }

        /// <summary>
        /// Optional. Restricted only. True, if the user can send animations, games, stickers and use inline bots, implies <see cref="CanSendMediaMessages"/>
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanSendOtherMessages { get; init; }

        /// <summary>
        /// Optional. Restricted only. True, if user may add web page previews to his messages, implies <see cref="CanSendMediaMessages"/>
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanAddWebPagePreviews { get; init; }
    }
}
