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
            
            foreach(var membrane in product)
            {
                membrane.MembraneConfigurations = membraneService.GetAllConfigurationByForeignKey(membrane.Id).Data;
            }

            return View(product);
        }
        
    }
}
