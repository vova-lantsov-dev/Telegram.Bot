using System.IO;
using System.Text.Json;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using Xunit;

namespace Telegram.Bot.Tests.Unit.Serialization
{
    public class InputFileSerializationTests
    {
        [Fact(DisplayName = "Should serialize & deserialize input file stream")]
        public void Should_Serialize_Input_File_Stream()
        {
            InputFileStream inputFile = new MemoryStream();

            string json = JsonSerializer.Serialize(inputFile, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            InputFileStream obj = JsonSerializer.Deserialize<InputFileStream>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.Equal("null", json);
            Assert.Equal(Stream.Null, obj.Content);
            Assert.Equal(FileType.Stream, obj.FileType);
            Assert.Null(obj.FileName);
        }

        [Fact(DisplayName = "Should serialize & deserialize input file with file_id")]
        public void Should_Serialize_Input_File_File_Id()
        {
            const string fileId = "This-is-a-file_id";
            InputTelegramFile inputFile = fileId;

            string json = JsonSerializer.Serialize(inputFile, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            InputTelegramFile obj = JsonSerializer.Deserialize<InputTelegramFile>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.Equal($@"""{fileId}""", json);
            Assert.Equal(fileId, obj.FileId);
            Assert.Equal(FileType.Id, obj.FileType);
            Assert.Null(obj.Content);
            Assert.Null(obj.FileName);
        }

        [Fact(DisplayName = "Should serialize & deserialize input file with URL")]
        public void Should_Serialize_Input_File_Url()
        {
            const string url = "http://github.org/TelegramBots";
            InputOnlineFile inputFile = url;

            string json = JsonSerializer.Serialize(inputFile, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            InputOnlineFile obj = JsonSerializer.Deserialize<InputOnlineFile>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));

            Assert.Equal($@"""{url}""", json);
            Assert.Equal(url, obj.Url);
            Assert.Equal(FileType.Url, obj.FileType);
            Assert.Null(obj.Content);
            Assert.Null(obj.FileName);
            Assert.Null(obj.FileId);
        }
    }
}
