using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRecipeSuggestionInformation
    {
        public List<RecipeSuggestionDTO> GetRecipes();
        public bool SaveRecipe(RecipeSuggestionDTO recipe);
        public bool RemoveRecipe(RecipeSuggestionDTO recipe);
        public RecipeSuggestionDTO GetRecipeByID(int id);
    }
}
