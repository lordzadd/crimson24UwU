using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Auth0.AspNetCore.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth0_Blazor.Pages
{
    public class CallbackModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            // Process the login callback
            var result = await HttpContext.AuthenticateAsync(Auth0Constants.AuthenticationScheme);

            // If the user is authenticated, redirect to the LoggedInHome page
            if (result.Succeeded)
            {
                return LocalRedirect("/LoggedInHome");
            }

            // If the user is not authenticated, redirect to the original home page
            return LocalRedirect("/");
        }
    }
}
