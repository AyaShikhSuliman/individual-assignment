using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookingOrganizer.Pages
{
    public class SuggestRecipeModel : PageModel
    {

        RecipeSuggestionManager recipeSuggestionManager;
        [BindProperty]
        public RecipeSuggestion RecipeSuggestion { get; set; }
        public string Message { get; set; }
        public SuggestRecipeModel()
        {

        }
        public void OnGet()
        {
            Message = "Hi, I see you would like to make a suggestion.\r\n   How cool! If you would like to contribute to this site feel free to fill out the information below. Thanks!";
        }
        public async Task<IActionResult> OnPost()
        {

            recipeSuggestionManager = Manager.Instance.GetRecipeSuggstionManager();
            if (ModelState.IsValid)
            {
                if (recipeSuggestionManager.CreateRecipe(RecipeSuggestion.Ingredients, RecipeSuggestion.Owner, RecipeSuggestion.Description, RecipeSuggestion.Name))
                {
                    Message = $"Thank you for your suggestion! We will take it into consideration and maybe include it in our website!";
                    return Page();
                }
                else
                {
                    Message = $"Your suggestion was not sent due to an error. We are working on it!";
                    return Page();
                }
            }

            return Page();




        }
    }
}
