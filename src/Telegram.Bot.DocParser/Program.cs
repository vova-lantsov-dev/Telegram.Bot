using System.Collections.Immutable;
using System.Threading.Tasks;

namespace Telegram.Bot.DocParser
{
    internal static class Program
    {
        private static async Task Main()
        {
            TelegramBotDocParser parser = new();
            parser.LoadBotApiPage();
            parser.ParseBotApiPage();

            ImmutableArray<BotApiType> types = parser.Types;
            await TelegramBotDocWriter.WriteTypesAsync(types);
        }
    }
}
