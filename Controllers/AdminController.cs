using agrokorm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agrokorm.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if (ModelState.IsValid)
            {
                return View("AdminPanel");
            }
            else
            {
                return View("Error");
            }
            
        } 
        
        
    }
}
