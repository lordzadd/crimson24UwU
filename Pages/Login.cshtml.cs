
using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth0_Blazor.Pages
{
    public class LoginModel : PageModel
    {
        public async Task OnGet(string redirectUri = "/LoggedInHome")
        {
            var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
                .WithRedirectUri(redirectUri)
                .Build();

            await HttpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
        }
    }
}
