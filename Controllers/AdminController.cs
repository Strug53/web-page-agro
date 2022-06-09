using agrokorm.Models;
using agrokorm.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agrokorm.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMembraneService _service;

        public AdminController(IMembraneService service) { _service = service; }

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
                var listOfMembranes = _service.GetAllProduct().Data;
                var listOfMembraneConfigurationsOne = _service.GetAllConfiguration().Data;

                foreach(var product in listOfMembranes)
                {
                    foreach(var configuration in listOfMembraneConfigurationsOne)
                    {
                        if(product.Id == configuration.MembraneId)
                        {
                            product.membraneConfigurations.Add(configuration);
                        }
                    }
                }



                return View("AdminPanel", listOfMembranes);
            }
            else
            {
                return View("Error");
            }
            
        }
       
        
        
    }
}
