using agrokorm.Models;
using agrokorm.Models.Form;
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
        private readonly IMembraneService _membraneService;

        //public AdminController(IMembraneService membrservice) { _membraneService = membrservice; }
        public AdminController(IGlobalRepository repo, IMembraneService membrservice) { _repository = repo; _membraneService = membrservice; }

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
                
                var Membranes = _repository.GetMembraneTable();
                var MembraneConfiguration = _repository.GetMembraneConfigurationTable();



                ViewBag.Seeds = Seeds;
                ViewBag.Membranes = Membranes;
                ViewBag.MembraneConfiguration = MembraneConfiguration;

                var formPrice = new PriceChangingFormModel();

                

                return View("AdminPanel");
            }
            else
            {
                return View("Error");
            }
            
        }
        [HttpPost]
        public IActionResult SubmitNewPrice(PriceChangingFormModel form)
        {
            if (ModelState.IsValid)
            {
                bool IsOk;
                switch (form.Table)
                {
                    case "Membrane":
                        var membrane = _membraneService.ChangePrice(form.Id, form.Price);
                        IsOk = membrane.Data;
                        break;
                    case "Seed":
                        IsOk = false;
                        break;

                    case "Config":
                        IsOk = false;
                        break;

                    default:
                        IsOk = false;
                        break;
                }



                return View("SuccessOrFailure", IsOk);

            }
            return View("SuccessOrFailure", false);
        }
      
        //public IActionResult CreateNewEntity()
        
    }
}
