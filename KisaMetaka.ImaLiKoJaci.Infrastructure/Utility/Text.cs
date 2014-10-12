using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Utility
{
    public static class Text
    {
        public static string GetHiddenText(string input)
        {
            input = input.RemoveDiacritics();
            input = Regex.Replace(input, @"[A-za-z0-9]", "_ ");

            return input;
        }

        public static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            normalizedString = RemoveAllExtraSpace(normalizedString);

            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var filteredChar = FilterWithBlackList(c);
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(filteredChar);

                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(filteredChar);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private static readonly Dictionary<char, char> _characterBlackList = new Dictionary<char, char>
        {
            {'đ', 'd'}, {'Đ', 'D'}, {'š', 's' }, {'Š', 'S'}, {'ž', 'z'}, {'Ž', 'Z'}, {'ć', 'c'}, {'Ć', 'C'}, {'č', 'c'}, {'Č', 'C'}
        };

        private static char FilterWithBlackList(char c)
        {
            return _characterBlackList.ContainsKey(c)
                ? _characterBlackList[c]
                : c;
        }

        private static string RemoveAllExtraSpace(string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
    }
}
