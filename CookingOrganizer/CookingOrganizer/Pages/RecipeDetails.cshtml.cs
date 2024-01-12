using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookingOrganizer.Pages
{
    public class RecipeDetailsModel : PageModel
    {
        private int recipeId = 0;
        private readonly RecipeManager recipeManager;
        
        public RecipeDetailsModel()
        {
            recipeManager = Manager.Instance.GetRecipeManager();
        }
        public void OnGet(int id)
        {
            recipeId = id;
        }
        public string RecipeImageToBytes(Recipe recipe)
        {
            if (recipe.ImageInBytes == null)
            {
                return null;
            }

            return Convert.ToBase64String(recipe.ImageInBytes);
        }
        public Recipe GetRecipeById(int id)
        {
            id = recipeId;
            Recipe recipe = recipeManager.GetRecipeById(id);
            if (recipe == null)
            {
                return null;
            }
            return recipe;
        }
        public Recipe GetRecipe => GetRecipeById(recipeId);


    }
}
