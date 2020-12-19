

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Types
{
    /// <summary>
    /// Represents an audio file to be treated as music to be sent
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record InputMediaAudio : InputMediaBase, IInputMediaThumb
    {
        /// <summary>
        /// Optional. Title of the audio
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Title { get; init; }

        /// <summary>
        /// Optional. Performer of the audio
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Performer { get; init; }

        /// <summary>
        /// Optional. Duration of the audio in seconds
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Duration { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMedia Thumb { get; init; }

        /// <summary>
        /// Initializes a new audio media to send with an <see cref="InputMedia"/>
        /// </summary>
        public InputMediaAudio(InputMedia media)
        {
            Type = "audio";
            Media = media;
        }
    }
}
