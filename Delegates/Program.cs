using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var example =  new Example();
            
            // Basic delegate
            example.GiveMeAMethod(Sell);
            example.GiveMeAMethod(Buy);
            
            // Func
            example.GiveMeAFunc(Sell);
            example.GiveMeAFunc(Buy);
            
            // Action - no return type, just does a task
            example.GiveMeAnAction(Hold);
            
        }
        
        private static string Sell() => "Selling";
        private static string Buy() => "Buying";
        private static void Hold() => Console.WriteLine("Action -> Holding");
        
    }
}