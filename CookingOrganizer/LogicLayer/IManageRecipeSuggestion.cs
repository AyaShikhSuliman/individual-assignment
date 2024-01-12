using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface IManageRecipeSuggestion
    {
        public bool CreateRecipe(string ingredients, string owner, string description, string name);
        public bool DeleteRecipe(RecipeSuggestion recipe);
        public List<RecipeSuggestion> ShowRecipes();

    }
}
