namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents one row of the high scores table for a game.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record GameHighScore
    {
        /// <summary>
        /// Position in high score table for the game.
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Position { get; init; }

        /// <summary>
        /// User
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public User User { get; init; }

        /// <summary>
        /// Score
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public int Score { get; init; }
    }
}
