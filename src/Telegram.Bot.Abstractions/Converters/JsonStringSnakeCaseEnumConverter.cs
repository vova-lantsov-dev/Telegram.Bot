using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Telegram.Bot.Converters
{
    public sealed class JsonStringSnakeCaseEnumConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsEnum;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var converterFactory = new JsonStringEnumConverter(new SnakeCaseNamingPolicy(), false);
            return converterFactory.CreateConverter(typeToConvert, options);
        }
    }
}
