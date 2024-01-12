using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class Manager
    {
        public static Manager Instance
        {
            get;
        }
        static Manager()
        {
            Instance = new Manager();
        }
        public RecipeManager GetRecipeManager()
        {
            IRecipeInformation recipeInfo = new RecipeInfoDAL();
            RecipeManager manager = new RecipeManager(recipeInfo);
            return manager;
        }
        public UserManager GetUserManager()
        {
            IUserInformation userInformation = new UserInfoDAL();
            UserManager manager = new UserManager(userInformation);
            return manager;
        }
        public RecipeSuggestionManager GetRecipeSuggstionManager()
        {
            IRecipeSuggestionInformation recipeSuggestionInformation = new RecipeSuggestionInfoDAL();
            RecipeSuggestionManager recipeSuggestionManager = new RecipeSuggestionManager(recipeSuggestionInformation);
            return recipeSuggestionManager;
        }
    }
}
