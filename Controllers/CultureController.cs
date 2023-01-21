using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Maysam.Controllers
{
    public class CultureController : Controller
    {
        public IActionResult SetCulture(string culture ,string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return Redirect(returnUrl);
            // return LocalRedirect(returnUrl);
        }
    }
}
