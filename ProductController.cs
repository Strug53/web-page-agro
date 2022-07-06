using agrokorm.Models.Db;
using agrokorm.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agrokorm.Controllers
{
    public class ProductController : Controller
    {
       
        private readonly ISeedService _SeedService;
        private readonly IMembraneService _membraneService;
        private readonly ISzrService _szrService;

        public ProductController(IMembraneService service, ISeedService sunflowerSeedService, ISzrService szrService) 
        { 
            _szrService = szrService;
            _membraneService = service;
            _SeedService = sunflowerSeedService;
        }

        public IActionResult Membrane()
        {
            var product = _membraneService.GetAllProduct().Data;

            foreach (var membrane in product)
            {
                membrane.MembraneConfigurations = _membraneService.GetAllConfigurationByForeignKey(membrane.Id).Data;
            }

            return View(product);
        }

        
       

        public IActionResult Sunflower()
        {
            
            var SunflowerSeeds = _SeedService.GetAllSunflowers().Data;
            return View("Sunflower", SunflowerSeeds);
        }

        public IActionResult Szr()
        {
            var szrs = _szrService.GetAllProduct().Data;
            return View("Szr", szrs);
        }

        public IActionResult SpringSeed()
        {
            var seeds = _SeedService.GetAllSpringSeeds().Data;
            return View("SpringSeed", seeds);
        }

        public IActionResult Gumat7B() { return View(); }
       
    }
}
