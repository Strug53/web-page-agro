using agrokorm.Service.Interfaces;
using agrokorm.Service.ProductServices.MembraneService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using agrokorm.Service.Response;
using agrokorm.Models.Products;

namespace agrokorm.Controllers
{
    public class MembraneController : Controller
    {
        private readonly IMembraneService membraneService;

        public MembraneController(IMembraneService service) { membraneService = service; }

        public IActionResult Product()
        {
            var product = membraneService.GetAllProduct().Data;
            var configurationOne = membraneService.GetAllConfigurationByForeignKey(1).Data;
            var configurationTwo = membraneService.GetAllConfigurationByForeignKey(2).Data;

            product[0].membraneConfigurations = configurationOne;
            product[1].membraneConfigurations = configurationTwo;




            return View(product);
        }
        
    }
}
