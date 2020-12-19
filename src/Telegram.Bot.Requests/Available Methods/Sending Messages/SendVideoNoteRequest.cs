﻿using System.Net.Http;
using Telegram.Bot.Requests.Abstractions;
using Telegram.Bot.Requests.Helpers;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Send rounded video messages
    /// </summary>
    //[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed partial record SendVideoNoteRequest : FileRequestBase<Message>,
                                        INotifiableMessage,
                                        IReplyMessage,
                                        IReplyMarkupMessage<IReplyMarkup>,
                                        IThumbMediaMessage
    {
        /// <summary>
        /// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public ChatId ChatId { get; }

        /// <summary>
        /// Video note to send
        /// </summary>
        //[JsonProperty(Required = Required.Always)]
        public InputTelegramFile VideoNote { get; }

        /// <summary>
        /// Duration of sent video in seconds
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Duration { get; init; }

        /// <summary>
        /// Video width and height
        /// </summary>
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Length { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMedia Thumb { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableNotification { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ReplyToMessageId { get; init; }

        /// <inheritdoc />
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IReplyMarkup ReplyMarkup { get; init; }

        /// <summary>
        /// Initializes a new request with chatId and video note
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel</param>
        /// <param name="videoNote">Video note to send</param>
        public SendVideoNoteRequest(ChatId chatId, InputTelegramFile videoNote)
            : base("sendVideoNote")
        {
            ChatId = chatId;
            VideoNote = videoNote;
        }

        /// <inheritdoc />
        public override HttpContent ToHttpContent()
        {
            HttpContent httpContent;
            if (VideoNote.FileType == FileType.Stream || Thumb?.FileType == FileType.Stream)
            {
                var multipartContent = GenerateMultipartFormDataContent("video_note", "thumb");
                if (VideoNote.FileType == FileType.Stream)
                {
                    multipartContent.AddStreamContent(VideoNote.Content, "video_note", VideoNote.FileName);
                }

                if (Thumb?.FileType == FileType.Stream)
                {
                    multipartContent.AddStreamContent(Thumb.Content, "thumb", Thumb.FileName);
                }

                httpContent = multipartContent;
            }
            else
            {
                httpContent = base.ToHttpContent();
            }

            return httpContent;
        }
    }
}
