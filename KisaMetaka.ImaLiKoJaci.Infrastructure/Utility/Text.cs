using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Utility
{
    public static class Text
    {
        public static string GetHiddenText(this string str)
        {
            var cleanText = str.RemoveDiacriticalChars();

            var sb = new StringBuilder();
            foreach (var c in cleanText)
            {
                if (c != ' ') { sb.Append("_ "); }
                else { sb.Append(' ', 3); }
            }

            return sb.ToString();
        }

        public static string RemoveDiacriticalChars(this string str)
        {
            var dict = new Dictionary<char, char>
            {
                {'Č', 'C'}, {'č', 'c'},
                {'Ć', 'C'}, {'ć', 'c'},
                {'Ž', 'Z'}, {'ž', 'z'},
                {'Š', 'S'}, {'š', 's'},
                {'Đ', 'D'}, {'đ', 'd'},
            };

            var sb = new StringBuilder(str);
            foreach (var entry in dict) { sb.Replace(entry.Key, entry.Value); }
            return sb.ToString();
        }

        public static bool LyricEquals(this string str1, string str2)
        {
            var first = str1
                .RemoveDiacriticalChars()
                .RemoveAllExtraSpace();

            var second = str2
                .RemoveDiacriticalChars()
                .RemoveAllExtraSpace();

            return first.Equals(second, StringComparison.OrdinalIgnoreCase);
        }

        public static string RemoveAllExtraSpace(this string str)
        {
            return Regex.Replace(str, @"\s+", " ").Trim(' ');
        }
    }
}
