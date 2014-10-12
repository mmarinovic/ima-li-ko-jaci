using System.Text.RegularExpressions;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Utility
{
    public class Text
    {
        public static string GetHiddenText(string input)
        {
            input = Regex.Replace(input, @"[A-za-z0-9]", "_ ");

            return input;
        }
    }
}
