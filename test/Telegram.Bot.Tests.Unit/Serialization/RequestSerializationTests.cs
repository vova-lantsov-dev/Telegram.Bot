using System.Text.Json;
using Telegram.Bot.Requests;
using Xunit;

namespace Telegram.Bot.Tests.Unit.Serialization
{
    public class RequestSerializationTests
    {
        [Fact(DisplayName = "Should serialize request")]
        public void Should_Serialize_Request()
        {
            GetUpdatesRequest request = new GetUpdatesRequest
            {
                Offset = 12345
            };

            string serializeRequest = JsonSerializer.Serialize(request, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.DoesNotContain(@"""MethodName""", serializeRequest);
            Assert.DoesNotContain(@"""IsWebhookResponse""", serializeRequest);
        }

        [Fact(DisplayName = "Should properly serialize request with custom json settings")]
        public void Should_Properly_Serialize_Request_With_Custom_Json_Settings()
        {
            GetUpdatesRequest request = new GetUpdatesRequest
            {
                Offset = 12345
            };

            string serializeRequest = JsonSerializer.Serialize(request, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.DoesNotContain(@"""MethodName""", serializeRequest);
            Assert.DoesNotContain(@"""method_name""", serializeRequest);
            Assert.DoesNotContain(@"""IsWebhookResponse""", serializeRequest);
            Assert.DoesNotContain(@"""is_webhook_response""", serializeRequest);
            Assert.Contains(@"""offset"":12345", serializeRequest);
            Assert.DoesNotContain(@"""allowed_updates""", serializeRequest);
        }
    }
}
