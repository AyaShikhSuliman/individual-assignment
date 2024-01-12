using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MockRecipeInfoDAL : IRecipeInformation
    {
        public RecipeDTO GetRecipeByID(int id)
        {
            RecipeDTO recipeDTO = new RecipeDTO();
            return recipeDTO;
        }

        public List<RecipeDTO> GetRecipes()
        {
            return new List<RecipeDTO>();
        }

        public bool RemoveRecipe(RecipeDTO recipe)
        {
            return true;
        }

        public bool SaveRecipe(RecipeDTO recipe)
        {
            return true;
        }

        public bool UpdateRecipe(RecipeDTO recipe)
        {
            return true;
        }
    }
}
