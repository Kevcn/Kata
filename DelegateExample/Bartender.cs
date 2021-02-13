using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DelegateExample
{
    public class Bartender
    {
        private readonly RecipeBook _recipeBook;
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        
        public Bartender(RecipeBook recipeBook, Func<string> inputProvider, Action<string> outputProvider)
        {
            _recipeBook = recipeBook;
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
        }

        public void AskForDrink()
        {
            _outputProvider($"What drink would you like? ({string.Join(", ", _recipeBook.GetAvailableDrinks())})" );
            
            var drink = _inputProvider() ?? string.Empty;
            
            if (!_recipeBook.GetAvailableDrinks().Contains(drink))
            {
                _outputProvider("Drink not available.");
                return;
            }

            var serve = _recipeBook.GetRecipe(drink);
            // Here we are invoking the action!!
            serve();
        }
        
    }
}