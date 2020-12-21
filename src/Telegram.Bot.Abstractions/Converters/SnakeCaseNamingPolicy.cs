using System.Text.Json;

namespace Telegram.Bot.Converters
{
    internal sealed class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToSeparatedCase('_');
        }
    }
}
