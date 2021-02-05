using System;
using System.Diagnostics;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var worker = new Worker();

            try
            {
                worker.Call();
            }
            catch (CustomException cex)
            {
                // Gets the full stacktrace with line number! very important
                Console.WriteLine("-----------------");
                Console.WriteLine(cex);
                Console.WriteLine("-----------------");
                Console.WriteLine(cex.Demystify());
            }
            catch (Exception ex)
            {
                Console.WriteLine("This would never get hit as we are only throwing a custom exception");
            }
            
        }
    }
}