using System;
using System.Numerics;

namespace SumStringsAsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("", "5"));
            Console.WriteLine(sumStrings("712569312664357328695151392", "8100824045303269669937"));
            // Console.WriteLine(sumStrings("", "5"));
        }
        
        public static string sumStrings(string a, string b)
        {
            if (BigInteger.TryParse(a, out var n1) && BigInteger.TryParse(b, out var n2))
            {
                return (n1 + n2).ToString();
            }

            if (BigInteger.TryParse(a, out var n11))
            {
                return n11.ToString();
            }
            
            if (BigInteger.TryParse(b, out var n22))
            {
                return n22.ToString();
            }
            
            return String.Empty;
        }
    }
}