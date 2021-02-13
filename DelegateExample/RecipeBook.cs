using System;
using System.Collections.Generic;

namespace DelegateExample
{
    public class RecipeBook
    {
        private readonly Dictionary<string, Action> _recipes;
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        
        
        public RecipeBook(Func<string> inputProvider, Action<string> outputProvider)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _recipes = new Dictionary<string, Action>
            {
                {"beer", ServeBeer},
                {"juice", ServeJuice},
                
            };
        }

        public IEnumerable<string> GetAvailableDrinks()
        {
            return _recipes.Keys;
        }

        public Action GetRecipe(string drink)
        {
            return _recipes[drink];
        }
        
        private void ServeJuice()
        {
            _outputProvider("Here is a fresh juice.");
        }
        
        private void ServeBeer()
        {
            _outputProvider("Here is your beer.");
        }
        
    }
}