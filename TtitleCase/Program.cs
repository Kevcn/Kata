using System;
using System.Linq;
using System.Text;

namespace TtitleCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert("a clash of KINGS", "a an the of");
            
            var t2 = Convert("");

            Console.WriteLine(t2);
        }


        private static string Convert(string title, string minorWords = "")
        {
            if (title == "" || title is null)
                return title;

            var minor = minorWords is null ? new string[0] : minorWords.ToLower().Split(' ');
            var words = title.ToLower().Split(' ');
            var output = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (!minor.Contains(words[i]) || i == 0)
                {
                    output.Append(words[i].First().ToString().ToUpper() + words[i].Substring(1));
                }
                else
                {
                    output.Append(words[i]);
                }

                output.Append(" ");
            }
            
            return output.ToString().TrimEnd();
        } 
        
    }
}