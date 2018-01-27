using Microsoft.AspNetCore.Antiforgery;
using Cheer.Controllers;

namespace Cheer.Web.Host.Controllers
{
    public class AntiForgeryController : CheerControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
