using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralSolver
{
    class Program
    {
        // 1 - I
        // 5 - V
        // 10 - X
        // 50 - L
        // 100 - C
        // 500 - D
        // 1000 - M
        
        private static readonly Dictionary<int, string> _dictionary = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };
        
        /// <summary>
        /// Takes any integer - return the equivalent in roman numerals
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var number = 2391;
            
            // Count number of digits in an integer!
            // var numberLength = (int)Math.Floor(Math.Log10(number) + 1);
            
            var roman = new StringBuilder();

            foreach (var item in _dictionary)
            {
                while (number >= item.Key)
                {
                    roman.Append(item.Value);
                    number -= item.Key;
                }
            }

            Console.WriteLine(roman);
        }
    }
}