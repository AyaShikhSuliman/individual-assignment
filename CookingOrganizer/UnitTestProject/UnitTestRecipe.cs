using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using DataLayer;
using System.Drawing;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestRecipe
    {
        [TestMethod]
        public void TestConstructor()
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
            Assert.IsNotNull(recipe);
        }
        [TestMethod]
        public void TestIdProperty()
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
            Assert.AreEqual(recipe.Id, int.Parse("1"));
        }
        [TestMethod]
        public void TestNameProperty()
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
            Assert.AreEqual(recipe.Name, "Name");
        }
        [TestMethod]
        public void TestDescriptionProperty()
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
            Assert.AreEqual(recipe.Description, "Description");
        }
        [TestMethod]
        public void TestIngredientsProperty()
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
            Assert.AreEqual(recipe.Ingredients, "Ingredients");
        }
        [TestMethod]
        public void TestOwnerProperty()
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
            Assert.AreEqual(recipe.Owner, "Owner");
        }
        [TestMethod]
        public void TestGetInfoForDesktop()
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
            Assert.AreEqual(recipe.GetInfoForDesktop(), $"Recipe {recipe.Description}, with ingredients: {recipe.Ingredients}, owner: {recipe.Owner} and ID: {recipe.Id}");
        }
    }
}
