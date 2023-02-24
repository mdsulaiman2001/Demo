using Microsoft.AspNetCore.Mvc;
using SwordLMS.Web.Data;

namespace SwordLMS.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly SwordLMSContext _context;
        private readonly SwordLMSContext _db;

        public AdminController(SwordLMSContext context , SwordLMSContext db ) 
        {
            context = _context;
            db = _db;
        }
        public IActionResult AdminPage()
        {
            return View();
     
        }

        
    }
}
