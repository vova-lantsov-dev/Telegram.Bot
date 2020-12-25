namespace Telegram.Bot.DocParser
{
    internal sealed record BotApiTypeParameter
    {
        public string ParameterName { get; init; }
        public string ParameterDescription { get; init; }
        public string ParameterTypeName { get; init; }
        public bool IsEnum { get; init; }
    }
}
