using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Identity.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
