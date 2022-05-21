using System.Text;

namespace LeetCodeIt;

public class RomanInteger
{
    private static readonly Dictionary<string, int> _dictionary = new Dictionary<string, int>
    {
        { "M", 1000 },
        { "CM", 900},
        { "D", 500 },
        { "CD", 400 },
        { "C", 100 },
        { "XC", 90 },
        { "L", 50 },
        { "XL", 40 },
        { "X", 10 },
        { "IX", 9 },
        { "V", 5 },
        { "IV", 4 },
        { "I", 1 }
    };

    private static int Convert(string s)
    {
        var input = s;
        var output = 0;

        if (input.Length == 1)
        {
            return _dictionary[s];
        }


        var twoChars = input.Substring(0, 2);
        var oneChars = input.Substring(0, 1);

        while (input.Length != 0)
        {
            if (input.Length > 1)
            {
                twoChars = input.Substring(0, 2);
            }

            oneChars = input.Substring(0, 1);

            if (_dictionary.ContainsKey(twoChars))
            {
                output += _dictionary[twoChars];
                input = input.Substring(2, input.Length - 2);
            }
            else if (_dictionary.ContainsKey(oneChars))
            {
                output += _dictionary[oneChars];
                input = input.Substring(1, input.Length - 1);
            }

            twoChars = String.Empty;
        }

        return output;
    }

    public static void Run()
    {
        var input = "MDCXCV";

        var output = Convert(input);
    }

}