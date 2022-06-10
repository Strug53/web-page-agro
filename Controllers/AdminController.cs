using agrokorm.Models;
using agrokorm.Repository;
using agrokorm.Repository.Interfaces;
using agrokorm.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agrokorm.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGlobalRepository _repository;

        public AdminController(IGlobalRepository repo) { _repository = repo; }

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
                var Seeds = _repository.GetSeedTable();
                var SeedConfiguraions = _repository.GetSeedConfigurationsTable();
                var Membranes = _repository.GetMembraneTable();
                var MembraneConfigurations = _repository.GetMembraneConfigurationTable();

                //foreach(var membrane in Membranes)
                //{
                    //foreach(var membraneConfiguration in MembraneConfigurations) 
                    //{
                        //if(membrane.Id == membraneConfiguration.MembraneId) { membrane.membraneConfigurations.Add(membraneConfiguration); }
                    //}
                //}

                ViewBag.Seeds = Seeds;
                ViewBag.SeedConfiguraions = SeedConfiguraions;
                ViewBag.Membranes = Membranes;
                ViewBag.MembraneConfigurations = MembraneConfigurations;



                return View("AdminPanel");
            }
            else
            {
                return View("Error");
            }
            
        }
       
        
        
    }
}
