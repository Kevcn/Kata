using System;
using System.Collections.Generic;
using System.Linq;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = BruteForce("asd", "dsa");
            Console.WriteLine(result);
        }

        // O(n)
        public static bool BruteForce(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var sortedS1 = Sort(s1);
            var sortedS2 = Sort(s2);

            var result = sortedS1.Equals(sortedS2);

            return result;
        }

        public static string Sort(string input)
        {
            var chars = input.ToCharArray();
            Array.Sort(chars);

            return chars.ToString();
        }
    }
}