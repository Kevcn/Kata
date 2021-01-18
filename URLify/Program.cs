using System;
using System.Collections.Generic;
using System.Linq;

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Work("we are winners", 5));
        }

        public static string Work(string input, int length)
        {
            var output = new List<string>();
            
            foreach (var c in input)
            {
                output.Add(c == ' ' ? "%20" : c.ToString());
            }

            return String.Join("", output);
        }
    }
}