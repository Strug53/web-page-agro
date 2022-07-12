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
        private readonly IGrassMixtrueService _grassMixtrueService;

        public ProductController(IMembraneService service, ISeedService sunflowerSeedService, ISzrService szrService, IGrassMixtrueService grassMixtrueService)
        {
            _szrService = szrService;
            _membraneService = service;
            _SeedService = sunflowerSeedService;
            _grassMixtrueService = grassMixtrueService;
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
            return View(SunflowerSeeds);
        }

        public IActionResult Szr()
        {
            var szrs = _szrService.GetAllProduct().Data;
            return View(szrs);
        }

        public IActionResult SpringSeed()
        {
            var seeds = _SeedService.GetAllSpringSeeds().Data;
            return View(seeds);
        }

        public IActionResult Legumes()
        {
            var seeds = _SeedService.GetAllLegumes().Data;
            return View(seeds);
        }
        public IActionResult GrassSeed()
        {
            var seeds = _SeedService.GetAllGrassSeeds().Data;

            ViewBag.GrassMixture = _grassMixtrueService.GetAllProduct().Data;

            return View(seeds);
        }
        public IActionResult GrassMixture()
        {
            var mixtures = _grassMixtrueService.GetAllProduct().Data;
            return View(mixtures);
        }
        public IActionResult GrassMixtureInDetail(int id)
        {
            var mixture = _grassMixtrueService.GetProduct(id).Data;
            return View(mixture);
        } 
        public IActionResult Gumat7B() { return View(); }
       
        public IActionResult Seeds()
        {

            return View();
        }
    }
}
