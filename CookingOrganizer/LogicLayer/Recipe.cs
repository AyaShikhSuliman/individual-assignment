using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Buffers.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace LogicLayer
{
    public class Recipe
    {
        private int id;
        private string ingredients;
        private string description;
        private string owner;
        private Image image;
        private byte[] imageInBytes;
        private string name;

        public int Id { get { return id; } set { id = value; } }
        public string Ingredients { get { return ingredients; } set { ingredients = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Owner { get { return owner; } set { owner = value; } }
        public Image Image { get { return image; } set { image = value; } }
        public byte[] ImageInBytes { get { return imageInBytes; } set { imageInBytes = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Recipe(RecipeDTO recipeDTO)
        {
            Id = recipeDTO.Id;
            Ingredients = recipeDTO.Ingredients;
            Description = recipeDTO.Description;
            Owner = recipeDTO.Owner;
            Image = recipeDTO.Image;
            ImageInBytes = recipeDTO.ImageInBytes;
            Name = recipeDTO.Name;

        }

        public string GetInfoForDesktop()
        {
            return $"Recipe {description}, with ingredients: {ingredients}, owner: {owner} and ID: {id}";
        }
    }
}
