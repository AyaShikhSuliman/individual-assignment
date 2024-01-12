using LogicLayer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace CookingOrganizer.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Password { get; set; }
        private readonly IManageUser manageUser;
        Manager manager = new Manager();
        public UserManager userManager;
        public string Message { get; private set; }

        public void OnGet()
        {
            userManager = Manager.Instance.GetUserManager();
        }
        public async Task OnPost()
        {
            userManager = Manager.Instance.GetUserManager();
            
            User user = userManager.CreateUser(Name, Password);
            if (userManager.SaveUser(user))
            {
                Message = $"Hello {user.Name}, thank you for making registration in our website! Are you ready to become the best chef amongst your colleagues?";
            }
            else
            {
                Message = $"Something went wrong";
            }
            
        }
    }
}
