using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class RecipeManager : IManageRecipe, IShowRecipe
    {
        private readonly IRecipeInformation recipeInformation;
        //private readonly IRecipeInfoDAL recipeInformation;

        public RecipeManager(IRecipeInformation recipeInfo)
        {
            this.recipeInformation = recipeInfo
            ?? throw new ArgumentNullException(nameof(recipeInfo));
        }

        public bool CreateRecipe(string ingredients, string owner, string description, Image image, string name)
        {
            RecipeDTO recipeDTO = new RecipeDTO();
            recipeDTO.Ingredients = ingredients;
            recipeDTO.Owner = owner;
            recipeDTO.Description = description;
            recipeDTO.Image = image;
            recipeDTO.Name = name;
            if (ingredients == "" || description == "" || name == "")
            {
                return false;
            }
            else if (recipeInformation.SaveRecipe(recipeDTO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteRecipe(Recipe recipe)
        {
            RecipeDTO recipeDTO = new RecipeDTO();
            recipeDTO.Id = recipe.Id;
            if (recipeInformation.RemoveRecipe(recipeDTO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Recipe> ShowRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach (RecipeDTO recipeDTO in recipeInformation.GetRecipes())
            {
                recipes.Add(new Recipe(recipeDTO));
            }
            return recipes;
        }
        public Recipe GetRecipeById(int id)
        {
            Recipe recipe = new Recipe(recipeInformation.GetRecipeByID(id));
            return recipe;
        }

        public bool UpdateRecipe(Recipe recipe)
        {
            RecipeDTO recipeDTO = new RecipeDTO();
            recipeDTO.Ingredients = recipe.Ingredients;
            recipeDTO.Owner = recipe.Owner;
            recipeDTO.Description = recipe.Description;
            recipeDTO.Id = recipe.Id;
            recipeDTO.Image = recipe.Image;
            if (!recipeInformation.UpdateRecipe(recipeDTO))
            {
                return false;
            }
            return true;
        }

    }
}
