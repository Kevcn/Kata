using System;
using System.Linq;
using System.Text;

namespace SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Pig latin is cool"));
        }
        
        public static string PigIt(string str)
        {
            // Move the first letter of each word to the end of it, then add "ay" to the end of the word.
            // Leave punctuation marks untouched.
            
            var output = new StringBuilder();
            
            foreach (var word in str.Split(' '))
            {
                if (word.Select(char.IsPunctuation).First())
                {
                    output.Append(word);
                    continue;
                }
                
                var firstChar = word[0];
                var newWord = $"{word.Remove(0, 1)}{firstChar}ay ";
                output.Append(newWord);
            }
            
            return output.ToString().TrimEnd();
            
            // Or the one liner -
            return string.Join(" ", 
                str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }
    }
}