using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Půjčovna


{
    [Microsoft.AspNetCore.Mvc.Route("/[controller]")]
    [ApiController]
    public class CultureControler : ControllerBase
    {
        public ActionResult SetCulture()
        {
            IRequestCultureFeature culture = HttpContext.Features.Get<IRequestCultureFeature>();
            string refererUrl = Request.Headers["Referer"];
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(new string[] { "en-US", "cs-CZ" }
                    .Where(option => option != culture.RequestCulture.Culture.Name)
                    .FirstOrDefault())),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });


            return Redirect(refererUrl);
        }
    }
}
