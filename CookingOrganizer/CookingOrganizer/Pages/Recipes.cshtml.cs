using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;

namespace CookingOrganizer.Pages
{
    [Authorize]
    public class RecipesModel : PageModel
    {
        private readonly RecipeManager recipeManager;
        Manager manager = new Manager();
        public string RecipeImageToBytes(Recipe recipe)
        {
            if (recipe.ImageInBytes == null)
            {
                return null;
            }

            return Convert.ToBase64String(recipe.ImageInBytes);
        }
        public RecipesModel()
        {
            recipeManager = Manager.Instance.GetRecipeManager();
        }


        public void OnGet()
        {
        }

        public IEnumerable<Recipe> Recipes => recipeManager.ShowRecipes();
        //public FileContentResult myAction(byte[] bytes)
        //{
        //    return new FileContentResult(bytes, "image/jpg");
        //}
    }
}
