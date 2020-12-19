namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a phone contact.
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed record Contact
    {
        /// <summary>
        /// Contact's phone number
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string PhoneNumber { get; init; }

        /// <summary>
        /// Contact's first name
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public string FirstName { get; init; }

        /// <summary>
        /// Optional. Contact's last name
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; init; }

        /// <summary>
        /// Optional. Contact's user identifier in Telegram
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int UserId { get; init; }

        /// <summary>
        /// Optional. Additional data about the contact in the form of a vCard
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Vcard { get; init; }
    }
}
