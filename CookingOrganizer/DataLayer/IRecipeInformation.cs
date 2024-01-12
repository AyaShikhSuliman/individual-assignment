using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRecipeInformation
    {
        public List<RecipeDTO> GetRecipes();
        public bool SaveRecipe(RecipeDTO recipe);
        public bool RemoveRecipe(RecipeDTO recipe);
        public RecipeDTO GetRecipeByID(int id);
        //public bool LoadRecipe(Recipe recipe);
        public bool UpdateRecipe(RecipeDTO recipe);
    }
}
