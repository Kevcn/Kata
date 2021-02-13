using System;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipeBook = new RecipeBook(Console.ReadLine, Console.WriteLine);
            var bartender = new Bartender(recipeBook, Console.ReadLine, Console.WriteLine);

            while (true)
            {
                bartender.AskForDrink();
            }
        }
    }
}