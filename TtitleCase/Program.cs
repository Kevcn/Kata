using System;
using System.Linq;
using System.Text;

namespace TtitleCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var example1 = Convert("a clash of KINGS", "a an the of");
            var example2 = Convert("THE WIND IN THE WILLOWS", "The In");
            var example3 = Convert("the quick brown fox");
            
            Console.WriteLine($"{example1}{Environment.NewLine}{example2}{Environment.NewLine}{example3}");
            Console.WriteLine($"{Environment.Version}");
            Console.WriteLine($"{Environment.ProcessorCount}");
            Console.WriteLine($"{Environment.TickCount}");
            Console.WriteLine($"{Environment.UserName}");
            Console.WriteLine($"{Environment.UserDomainName}");
            Console.WriteLine($"{Environment.MachineName}");
            Console.WriteLine($"{Environment.CommandLine}");
            Console.WriteLine($"{Environment.OSVersion}");
            Console.WriteLine($"{Environment.ExitCode}");
            Console.WriteLine($"{Environment.CurrentManagedThreadId}");
            Console.WriteLine($"{Environment.WorkingSet}");
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