using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using LogicLayer;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestRecipeLogic
    {
        private static MockRecipeInfoDAL mockRecipeInfoDAL = new MockRecipeInfoDAL();
        private readonly RecipeManager recipeManager1 = new RecipeManager(mockRecipeInfoDAL);

        [TestMethod]
        public void TestConstructor()
        {
            RecipeManager recipeManager = new RecipeManager(new MockRecipeInfoDAL());
            Assert.ReferenceEquals(recipeManager, recipeManager1);
        }
        [TestMethod]
        public void TestCreateRecipe()
        {
            bool isDone = recipeManager1.CreateRecipe("Ingredients", "Owner", "Description", null, "Name");
            Assert.AreEqual(isDone, true);
        }
        [TestMethod]
        public void TestDeleteRecipe()
        {
            RecipeDTO recipeDTO = new RecipeDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            recipeDTO.Image = null;
            recipeDTO.ImageInBytes = null;
            Recipe recipe = new Recipe(recipeDTO);
            bool isDone = recipeManager1.DeleteRecipe(recipe);
            Assert.AreEqual(isDone, true);
        }
        [TestMethod]
        public void ShowRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();
            
            CollectionAssert.AreEqual(recipes, recipeManager1.ShowRecipes());

        }
        [TestMethod]
        public void TestUpdateRecipe()
        {
            RecipeDTO recipeDTO = new RecipeDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            recipeDTO.Image = null;
            recipeDTO.ImageInBytes = null;
            Recipe recipe = new Recipe(recipeDTO);
            bool isDone = recipeManager1.UpdateRecipe(recipe);
            Assert.AreEqual(isDone, true);
        }
    }
}
