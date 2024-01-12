using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MockRecipeSuggestionInfoDAL : IRecipeSuggestionInformation
    {
        public RecipeSuggestionDTO GetRecipeByID(int id)
        {
            RecipeSuggestionDTO recipe = new RecipeSuggestionDTO();
            return recipe;

        }

        public List<RecipeSuggestionDTO> GetRecipes()
        {
            List<RecipeSuggestionDTO> recipes = new List<RecipeSuggestionDTO>();
            return recipes;
        }

        public bool RemoveRecipe(RecipeSuggestionDTO recipe)
        {
            return true;
        }

        public bool SaveRecipe(RecipeSuggestionDTO recipe)
        {
            return true;
        }
    }
}
