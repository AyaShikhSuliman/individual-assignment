using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class RecipeSuggestionManager : IManageRecipeSuggestion
    {
        private readonly IRecipeSuggestionInformation recipeSuggestionInformation;
        public RecipeSuggestionManager(IRecipeSuggestionInformation recipeSuggestionInformation)
        {
            this.recipeSuggestionInformation = recipeSuggestionInformation
            ?? throw new ArgumentNullException(nameof(recipeSuggestionInformation));
        }

        public bool CreateRecipe(string ingredients, string owner, string description, string name)
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Ingredients = ingredients;
            recipeDTO.Owner = owner;
            recipeDTO.Description = description;
            recipeDTO.Name = name;
            if (recipeSuggestionInformation.SaveRecipe(recipeDTO))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public RecipeSuggestion GetRecipeById(int id)
        {
            RecipeSuggestion recipe = new RecipeSuggestion(recipeSuggestionInformation.GetRecipeByID(id));
            return recipe;
        }

        public bool DeleteRecipe(RecipeSuggestion recipe)
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = recipe.Id;
            if (recipeSuggestionInformation.RemoveRecipe(recipeDTO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<RecipeSuggestion> ShowRecipes()
        {
            List<RecipeSuggestion> recipes = new List<RecipeSuggestion>();
            foreach (RecipeSuggestionDTO recipeDTO in recipeSuggestionInformation.GetRecipes())
            {
                recipes.Add(new RecipeSuggestion(recipeDTO));
            }
            return recipes;
        }
    }
}
