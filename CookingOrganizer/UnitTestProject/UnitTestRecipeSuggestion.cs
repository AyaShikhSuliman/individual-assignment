using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestRecipeSuggestion
    {
        [TestMethod]
        public void TestConstructor()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.IsNotNull(recipe);
        }
        [TestMethod]
        public void TestIdProperty()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.AreEqual(recipe.Id, int.Parse("1"));
        }
        [TestMethod]
        public void TestNameProperty()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.AreEqual(recipe.Name, "Name");
        }
        [TestMethod]
        public void TestDescriptionProperty()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.AreEqual(recipe.Description, "Description");
        }
        [TestMethod]
        public void TestIngredientsProperty()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.AreEqual(recipe.Ingredients, "Ingredients");
        }
        [TestMethod]
        public void TestOwnerProperty()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.AreEqual(recipe.Owner, "Owner");
        }
        [TestMethod]
        public void TestGetInfoForDesktop()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.AreEqual(recipe.GetInfoForDesktop(), $"Recipe suggestion with ID - {recipe.Id} and Name: {recipe.Name} ");
        }
        public void TestDetailedInfo()
        {
            RecipeSuggestionDTO recipeDTO = new RecipeSuggestionDTO();
            recipeDTO.Id = int.Parse("1");
            recipeDTO.Name = "Name";
            recipeDTO.Description = "Description";
            recipeDTO.Ingredients = "Ingredients";
            recipeDTO.Owner = "Owner";
            RecipeSuggestion recipe = new RecipeSuggestion(recipeDTO);
            Assert.AreEqual(recipe.DetailedInfo(), $"Recipe {recipe.Description}, with ingredients: {recipe.Ingredients}, owner: {recipe.Owner} and ID: {recipe.Id}");
        }

    }
}
