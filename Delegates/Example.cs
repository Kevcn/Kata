using System;

namespace Delegates
{
    public class Example
    {
        // Essentially passing in a function.
        // Remember to actually call the function to execute it!
        public void GiveMeAMethod(DoAction tradeAction)
        {
            // What we get after actually calling the function
            var text = tradeAction();
            
            Console.WriteLine($"Basic Delegate -> {text}");
        }

        public delegate string DoAction();

        public void GiveMeAFunc(Func<string> tradeAction)
        {
            var text = tradeAction();
            Console.WriteLine($"Func -> {text}");
        }

        // The function we pass in as Action must be a void function!
        public void GiveMeAnAction(Action action)
        {
            // we'll execute the function/Action within here and do whatever
            action();
        }
    }
}