using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Helpers
{
    /// <summary>
    /// Extension Methods
    /// </summary>
    public static class Extensions
    {
        internal static string EncodeUtf8(this string value) =>
            string.Join(string.Empty, Encoding.UTF8.GetBytes(value).Select(Convert.ToChar));

        internal static void AddStreamContent(
            this MultipartFormDataContent multipartContent,
            Stream content,
            string name,
            string? fileName = default)
        {
            fileName ??= name;
            string contentDisposition = $@"form-data; name=""{name}""; filename=""{fileName}""".EncodeUtf8();

            HttpContent mediaPartContent = new StreamContent(content)
            {
                Headers =
                {
                    {"Content-Type", "application/octet-stream"},
                    {"Content-Disposition", contentDisposition}
                }
            };

            multipartContent.Add(mediaPartContent, name, fileName);
        }

        internal static void AddContentIfInputFileStream(
            this MultipartFormDataContent multipartContent,
            params IInputMedia[] inputMedia
        )
        {
            foreach (var input in inputMedia)
            {
                if (input.Media.FileType == FileType.Stream)
                {
                    multipartContent.AddStreamContent(input.Media.Content, input.Media.FileName);
                }

                var mediaThumb = (input as IInputMediaThumb)?.Thumb;
                if (mediaThumb?.FileType == FileType.Stream)
                {
                    multipartContent.AddStreamContent(mediaThumb.Content, mediaThumb.FileName);
                }
            }
        }
    }
}
