using System.Collections.Generic;

namespace Telegram.Bot.DocParser
{
    internal sealed record BotApiType
    {
        public string TypeName { get; init; }
        public string TypeDescription { get; init; }
        public List<BotApiTypeParameter> Parameters { get; init; }
    }
}
