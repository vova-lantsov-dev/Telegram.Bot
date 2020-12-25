using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using Telegram.Bot.DocParser.Exceptions;

namespace Telegram.Bot.DocParser
{
    internal sealed class TelegramBotDocParser
    {
        private const string BotApiUrl = "https://core.telegram.org/bots/api";

        private string _html;
        private readonly List<BotApiType> _types = new();

        public ImmutableArray<BotApiType> Types => _types.ToImmutableArray();

        public void LoadBotApiPage()
        {
            using var webClient = new WebClient();
            _html = webClient.DownloadString(BotApiUrl);
        }

        public void ParseBotApiPage()
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(_html);

            HtmlNodeCollection types = doc.DocumentNode.SelectNodes("//h4");
            foreach (HtmlNode typeNameNode in types)
            {
                HtmlNode typeDescriptionNode = typeNameNode.NextSibling;
                try
                {
                    var botApiType = new BotApiType
                    {
                        TypeName = typeNameNode.GetDirectInnerText(),
                        TypeDescription = typeDescriptionNode.InnerText,
                        Parameters = GetParametersForType(typeDescriptionNode)
                    };
                    _types.Add(botApiType);
                }
                catch (WrongTypeSignatureException)
                {
                }
                catch (NullReferenceException)
                {
                }
            }
        }

        private static List<BotApiTypeParameter> GetParametersForType(HtmlNode typeDescriptionNode)
        {
            List<BotApiTypeParameter> parameters = new();
            HtmlNode parametersTableNode = typeDescriptionNode.NextSibling;

            foreach (HtmlNode tr in parametersTableNode.SelectSingleNode("./tbody").ChildNodes)
            {
                HtmlNodeCollection tds = tr.ChildNodes;

                if (tds.Count != 3)
                {
                    // This entry is not a type, but a method description
                    throw new WrongTypeSignatureException();
                }

                HtmlNode parameterName = tds[0];
                HtmlNode parameterType = tds[1];
                HtmlNode parameterDescription = tds[2];

                var botApiTypeParameter = new BotApiTypeParameter
                {
                    ParameterName = parameterName.InnerText,
                    ParameterTypeName = GetDotNetTypeName(parameterType.InnerText),
                    ParameterDescription = parameterDescription.InnerText,
                    IsEnum = false
                };
                parameters.Add(botApiTypeParameter);
            }

            return parameters;
        }

        private static string GetDotNetTypeName(string parameterTypeName)
        {
            return parameterTypeName switch
            {
                "String" => "string",
                "Integer" => "int",
                "Boolean" or "True" => "bool",
                "Float" or "Float number" => "float",
                "InputFile or String" => GetDotNetTypeName("InputMedia"),
                "InlineKeyboardMarkup or ReplyKeyboardMarkup or ReplyKeyboardRemove or ForceReply" => GetDotNetTypeName("IReplyMarkup"),
                { } value when value.StartsWith("Array of") => $"System.Collections.Generic.List<{GetDotNetTypeName(value.Split(' ', 3)[2])}>",
                { } value => $"Telegram.Bot.Types.{value}",
                _ => throw new NotSupportedException()
            };
        }
    }
}
