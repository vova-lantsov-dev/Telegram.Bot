using System.IO;
using System.Text.Json;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Xunit;

namespace Telegram.Bot.Tests.Unit.Serialization
{
    public class InputMediaSerializationTests
    {
        [Fact(DisplayName = "Should serialize & deserialize input media from stream")]
        public void Should_Serialize_Input_Media_Stream()
        {
            const string fileName = "myFile";
            InputMedia inputMedia = new InputMedia(new MemoryStream(), fileName);

            string json = JsonSerializer.Serialize(inputMedia, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            InputMedia obj = JsonSerializer.Deserialize<InputMedia>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.Equal($@"""attach://{fileName}""", json);
            Assert.Equal(Stream.Null, obj.Content);
            Assert.Equal(fileName, obj.FileName);
            Assert.Equal(FileType.Stream, obj.FileType);
            Assert.Null(obj.FileId);
            Assert.Null(obj.Url);
        }

        [Fact(DisplayName = "Should serialize & deserialize input media with file_id")]
        public void Should_Serialize_Input_Media_File_Id()
        {
            const string fileId = "This-is-a-file_id";
            InputMedia inputMedia = fileId;

            string json = JsonSerializer.Serialize(inputMedia, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            InputMedia obj = JsonSerializer.Deserialize<InputMedia>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.Equal($@"""{fileId}""", json);
            Assert.Equal(fileId, obj.FileId);
            Assert.Equal(FileType.Id, obj.FileType);
            Assert.Null(obj.Content);
            Assert.Null(obj.FileName);
            Assert.Null(obj.Url);
        }

        [Fact(DisplayName = "Should serialize & deserialize input media with URL")]
        public void Should_Serialize_Input_Media_Url()
        {
            const string url = "http://github.org/TelgramBots";
            InputMedia inputMedia = url;

            string json = JsonSerializer.Serialize(inputMedia, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            InputMedia obj = JsonSerializer.Deserialize<InputMedia>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.Equal($@"""{url}""", json);
            Assert.Equal(url, obj.Url);
            Assert.Equal(FileType.Url, obj.FileType);
            Assert.Null(obj.Content);
            Assert.Null(obj.FileName);
            Assert.Null(obj.FileId);
        }
    }
}
