using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class RecipeSuggestion
    {
        private int id;
        private string ingredients;
        private string description;
        private string owner;
        private string name;

        public int Id { get { return id; } set { id = value; } }
        [Required]
        [StringLength(25, ErrorMessage = "The minimum allowed length of a name is 3 characters.", MinimumLength = 3)]
        public string Ingredients { get { return ingredients; } set { ingredients = value; } }
        [Required]
        [StringLength(25, ErrorMessage = "The minimum allowed length of a name is 3 characters.", MinimumLength = 3)]
        public string Description { get { return description; } set { description = value; } }
        
        [StringLength(25, ErrorMessage = "The minimum allowed length of a name is 3 characters.", MinimumLength = 3)]
        public string Owner { get { return owner; } set { owner = value; } }
        [Required]
        [StringLength(25, ErrorMessage = "The minimum allowed length of a name is 3 characters.", MinimumLength = 3)]
        public string Name { get { return name; } set { name = value; } }

        public RecipeSuggestion()
        {

        }
        public RecipeSuggestion(RecipeSuggestionDTO recipeDTO)
        {
            Id = recipeDTO.Id;
            Ingredients = recipeDTO.Ingredients;
            Description = recipeDTO.Description;
            Owner = recipeDTO.Owner;
            Name = recipeDTO.Name;

        }

        public string GetInfoForDesktop()
        {
            return $"Recipe suggestion with Name: {name} and ID: {id}";
        }
        public string DetailedInfo()
        {
            return $"Recipe {description}, with ingredients: {ingredients}, owner: {owner} and ID: {id}";
        }
    }
}
