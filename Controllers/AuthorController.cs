using Microsoft.AspNetCore.Mvc;

namespace SwordLMS.Web.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthorPage()
        {
            return View();
        }

    }
}
