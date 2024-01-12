using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestRecipeSuggestionLogic
    {
        private static MockRecipeSuggestionInfoDAL mockRecipeSuggestionInfoDAL = new MockRecipeSuggestionInfoDAL();
        private readonly RecipeSuggestionManager recipeSuggestionManager1 = new RecipeSuggestionManager(mockRecipeSuggestionInfoDAL);

        [TestMethod]
        public void TestConstructor()
        {
            RecipeManager recipeManager = new RecipeManager(new MockRecipeInfoDAL());
            Assert.ReferenceEquals(recipeManager, recipeSuggestionManager1);
        }
        [TestMethod]
        public void TestCreateRecipe()
        {
            bool isDone = recipeSuggestionManager1.CreateRecipe("Ingredients", "Owner", "Description", "Name");
            Assert.AreEqual(isDone, true);
        }
        [TestMethod]
        public void TestDeleteRecipe()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            bool isDone = recipeSuggestionManager1.DeleteRecipe(recipe);
            Assert.AreEqual(isDone, true);
        }
        [TestMethod]
        public void ShowRecipes()
        {
            List<RecipeSuggestion> recipes = new List<RecipeSuggestion>();

            CollectionAssert.AreEqual(recipes, recipeSuggestionManager1.ShowRecipes());

        }
        
    }
}
