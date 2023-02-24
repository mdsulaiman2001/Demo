using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwordLMS.Web.Models;
using System.Diagnostics;
using SwordLMS.Web.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace SwordLMS.Web.Controllers
{
    public class UserController : Controller
    {
        

        private readonly SwordLMSContext _db;
        private readonly  SwordLMSContext _context;
        private readonly Country _country;
        private readonly User _user ;


        public UserController(SwordLMSContext db ,SwordLMSContext context)
        {
            _db = db;
            _context = context;
           //_country= country;
        }

        

        public IActionResult SignUp()
        {
            

            //var countries =  _country.CountryName.ToList();

            var countries = _context.Country.ToList();
            var states = _context.State.ToList();
            var cities = _context.City.ToList();

              ViewBag.countires = _context.Country.ToList();
              ViewBag.states = _context.State.ToList();
              ViewBag.cities = _context.City.ToList();

            return View();
                 
        }

        public IActionResult Typeofuser()
        {
           
            return View();

        }

        public IActionResult Login()
        {
            var roles = _context.Role.ToList();
            ViewBag.roles = _context.Role.ToList();
            return RedirectToAction ("AdminController / AdminPage");
        }

        public IActionResult OnGetAsync()
        {
            return View();
        }
        
        public async Task<IActionResult> SaveSignUp (User user)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }

        //public async Task<IActionResult> SaveLogin()
        //{
        //    //await _context.SaveChangesAsync();
        //    return RedirectToAction("AdminPage","AdminController");
        //    //return RedirectToRoute("AdminController")
        //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}