using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Web;
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
                HtmlNode typeDescriptionNode = GetNextSibling(typeNameNode);
                try
                {
                    var botApiType = new BotApiType
                    {
                        TypeName = typeNameNode.GetDirectInnerText(),
                        TypeDescription = DecodeDescription(typeDescriptionNode.InnerText),
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
            HtmlNode parametersTableNode = GetNextSibling(typeDescriptionNode);

            foreach (HtmlNode tr in parametersTableNode.SelectSingleNode("./tbody").ChildNodes.Where(n => n.InnerText != "\n"))
            {
                var tds = tr.ChildNodes.Where(n => n.InnerText != "\n").ToArray();

                if (tds.Length != 3)
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
                    ParameterDescription = DecodeDescription(parameterDescription.InnerText),
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

        private static HtmlNode GetNextSibling(HtmlNode node)
        {
            HtmlNode sibling = node.NextSibling;
            while (sibling.OuterHtml == "\n")
            {
                sibling = sibling.NextSibling;
            }

            return sibling;
        }

        private static string DecodeDescription(string description)
        {
            string decoded = HttpUtility.HtmlDecode(description);
            string withNewLines = Regex.Replace(decoded, "\\.([A-Z0-9])", ".\n$1");
            return withNewLines;
        }
    }
}
