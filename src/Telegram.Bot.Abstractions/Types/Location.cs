﻿namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a point on the map.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record Location
    {
        /// <summary>
        /// Longitude as defined by sender
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public float Longitude { get; init; }

        /// <summary>
        /// Latitude as defined by sender
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public float Latitude { get; init; }
    }
}
