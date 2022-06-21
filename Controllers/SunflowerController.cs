using agrokorm.Models.Db;
using agrokorm.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace agrokorm.Controllers
{
    public class SunflowerController : Controller
    {
        private readonly ProductContext _db;
        private readonly ISunflowerSeedService _sunflowerSeedService; 
        public SunflowerController(ProductContext db, ISunflowerSeedService sunflowerSeedService)
        {
            _db = db;
            _sunflowerSeedService = sunflowerSeedService;
        }

        // GET: SunflowerController
        public IActionResult Index()
        {
            var viewModel = _db.SunFlowerViewModels.FirstOrDefault();
            ViewBag.SunFlowerViewModels = viewModel.Description;

            var SunflowerSeeds = _sunflowerSeedService.GetAllProduct().Data;
            return View("product", SunflowerSeeds);
        }

        
    }
}
