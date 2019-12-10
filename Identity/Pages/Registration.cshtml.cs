using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Identity.Pages
{
    public class RegistrationModel : PageModel
    {
        public RegistrationModel(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public UserManager<IdentityUser> UserManager { get; }

        public void OnGet()
        {

        }
        public async Task OnPostAsync()
        {
            var user = new IdentityUser {Email = Email, UserName = Email};
            var result = await UserManager.CreateAsync(user, Password);
        }
    }
}