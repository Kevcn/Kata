using System;

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
            }
            catch (Exception ex)
            {
                Console.WriteLine("This would never get hit as we are only throwing a custom exception");
            }
            
        }
    }
}