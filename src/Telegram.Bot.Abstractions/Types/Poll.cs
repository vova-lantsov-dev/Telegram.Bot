using System;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object contains information about a poll.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record Poll
    {
        /// <summary>
        /// Unique poll identifier
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Id { get; init; }

        /// <summary>
        /// Poll question, 1-255 characters
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Question { get; init; }

        /// <summary>
        /// List of poll options
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public PollOption[] Options { get; set; }

        /// <summary>
        /// Total number of users that voted in the poll
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int TotalVoterCount { get; init; }

        /// <summary>
        /// True, if the poll is closed
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public bool IsClosed { get; init; }

        /// <summary>
        /// True, if the poll is anonymous
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public bool IsAnonymous { get; init; }

        /// <summary>
        /// Poll type, currently can be “regular” or “quiz”
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Type { get; init; }

        /// <summary>
        /// True, if the poll allows multiple answers
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public bool AllowsMultipleAnswers { get; init; }

        /// <summary>
        /// Optional. 0-based identifier of the correct answer option. Available only for polls in the quiz mode, which are closed, or was sent (not forwarded) by the bot or to the private chat with the bot.
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? CorrectOptionId { get; init; }

        /// <summary>
        /// Optional. Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Explanation { get; init; }

        /// <summary>
        /// Optional. Special entities like usernames, URLs, bot commands, etc. that appear in the <see cref="Explanation"/>
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] ExplanationEntities { get; set; }

        /// <summary>
        /// Optional. Amount of time in seconds the poll will be active after creation
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? OpenPeriod { get; init; }

        /// <summary>
        /// Optional. Point in time when the poll will be automatically closed
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        //[JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CloseDate { get; init; }
    }
}
