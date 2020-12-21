using System;

namespace Telegram.Bot.Converters
{
    internal static class SeparatedCaseNamingExtensions
    {
        internal static string ToSeparatedCase(this string name, char separator)
        {
            if (string.IsNullOrEmpty(name))
                return string.Empty;

            int countOfWordsInPropertyName = 0;
            ReadOnlySpan<char> nameSpan = name.AsSpan();

            foreach (char nameChar in nameSpan)
                if (char.IsUpper(nameChar))
                    countOfWordsInPropertyName++;

            if (countOfWordsInPropertyName == 1)
            {
                return string.Create(nameSpan.Length, name,
                    (Span<char> destination, string source) =>
                    {
                        source.AsSpan().CopyTo(destination);
                        destination[0] = char.ToLowerInvariant(destination[0]);
                    });
            }

            return string.Create(nameSpan.Length + countOfWordsInPropertyName - 1, separator,
                (Span<char> destination, char separatorChar) =>
                {
                    ConvertToSeparatedCase(destination, name.AsSpan(), separatorChar);
                });
        }

        private static void ConvertToSeparatedCase(Span<char> destination, ReadOnlySpan<char> nameSpan, char separator)
        {
            int position = 0;

            foreach (char nameChar in nameSpan)
            {
                if (char.IsUpper(nameChar))
                {
                    if (position > 0)
                        destination[position++] = separator;
                    destination[position++] = char.ToLowerInvariant(nameChar);
                }
                else
                {
                    destination[position++] = nameChar;
                }
            }
        }
    }
}
