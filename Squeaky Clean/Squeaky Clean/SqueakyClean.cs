using System.Globalization;
using System.Text;

namespace Squeaky_Clean;

public static class Identifier
{
    public static string Clean(string identifier)
    {
     
        identifier = identifier.Replace(' ', '_');
        identifier = identifier.Replace("\0", "CTRL");
        identifier = identifier.Replace(@"[\u0391-\u03A1\u03A3-\u03A9\u03B1-\u03C1\u03C3-\u03C9]", string.Empty);

        if (identifier.Contains('-') == true)
        {
            string[] stringToSplit = identifier.Split('-');

            var charToUpper = char.ToUpper(stringToSplit[1][0]);

            StringBuilder sb = new();
            sb.Append(stringToSplit[0]);
            sb.Append(charToUpper);
            sb.Append(stringToSplit[1][1]);

            identifier = sb.ToString();
        }

        StringBuilder onlyLetters = new();

        foreach (char c in identifier)
        {
            if (IsGreekCharacter(c))
                continue;

            if (c == '_' || char.IsLetter(c) || c == 'Đ')
            {
                onlyLetters.Append(c);
            }
        }

        identifier = onlyLetters.ToString();


        return identifier;
    }

    private static bool IsGreekCharacter(char c)
    {
        return (c >= '\u0391' && c <= '\u03A1') || 
               (c >= '\u03A3' && c <= '\u03A9') || 
               (c >= '\u03B1' && c <= '\u03C1') || 
               (c >= '\u03C3' && c <= '\u03C9');   
    }
}