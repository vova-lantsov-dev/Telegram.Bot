namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a bot command
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record BotCommand
    {
        /// <summary>
        /// Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Command { get; init; }

        /// <summary>
        /// Description of the command, 3-256 characters.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string Description { get; init; }
    }
}
