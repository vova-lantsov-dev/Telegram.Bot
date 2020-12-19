using System;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a Telegram user or bot.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record User
    {
        /// <summary>
        /// Unique identifier for this user or bot
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Id { get; init; }

        /// <summary>
        /// True, if this user is a bot
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public bool IsBot { get; init; }

        /// <summary>
        /// User's or bot's first name
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string FirstName { get; init; }

        /// <summary>
        /// Optional. User's or bot's last name
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; init; }

        /// <summary>
        /// Optional. User's or bot's username
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; init; }

        /// <summary>
        /// Optional. IETF language tag of the user's language
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LanguageCode { get; init; }

        /// <summary>
        /// Optional. True, if the bot can be invited to groups. Returned only in getMe
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanJoinGroups { get; init; }

        /// <summary>
        /// Optional. True, if privacy mode is disabled for the bot. Returned only in getMe
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? CanReadAllGroupMessages { get; init; }

        /// <summary>
        /// Optional. True, if the bot supports inline queries. Returned only in getMe
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? SupportsInlineQueries { get; init; }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                // ReSharper disable NonReadonlyMemberInGetHashCode
                var hashCode = Id;
                hashCode = (hashCode * 397) ^ IsBot.GetHashCode();
                hashCode = (hashCode * 397) ^ (FirstName?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (LastName?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Username?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (LanguageCode?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (CanJoinGroups?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (CanReadAllGroupMessages?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (SupportsInlineQueries?.GetHashCode() ?? 0);
                // ReSharper restore NonReadonlyMemberInGetHashCode
                return hashCode;
            }
        }

        /// <inheritdoc/>
        public override string ToString() => (Username == null
                                                 ? FirstName + LastName?.Insert(0, " ")
                                                 : $"@{Username}") +
                                             $" ({Id})";
    }
}
