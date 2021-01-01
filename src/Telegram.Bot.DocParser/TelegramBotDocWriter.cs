using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.Bot.DocParser
{
    internal static class TelegramBotDocWriter
    {
        public static async Task WriteTypesAsync(ImmutableArray<BotApiType> types)
        {
            await using FileStream file = File.Create("types.json");
            await JsonSerializer.SerializeAsync(file, types);
        }
    }
}
