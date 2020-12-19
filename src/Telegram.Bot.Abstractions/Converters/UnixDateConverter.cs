using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Telegram.Bot.Converters
{
    public sealed class UnixDateConverter : JsonConverter<DateTime>
    {
        private static readonly DateTime Epoch = DateTime.UnixEpoch;

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            long unixTimestamp = reader.GetInt64();
            DateTime utcDate = Epoch.AddSeconds(unixTimestamp);
            DateTime localDate = utcDate.ToLocalTime();
            return localDate;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
