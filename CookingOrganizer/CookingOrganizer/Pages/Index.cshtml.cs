using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CookingOrganizer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public User User { get; set; }

        private readonly IManageUser manageUser;
        public string Message { get; set; }
        public UserManager userManager;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            userManager = Manager.Instance.GetUserManager();
        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            
            if (ModelState.IsValid == false)
            {
                //await HttpContext.ForbidAsync();
                Message = "Wrong credentials. The username must be atleast 3 words";
                return Page();
            }
            else if (!userManager.CheckExistence(User))
            {
                Message = "The user doesn't exist";
                return Page();
            }
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim("Name", User.Name));
            claims.Add(new Claim("ID", User.Id.ToString()));
            Message = "";
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
            return RedirectToPage("/Home");
        }
        
    }
}