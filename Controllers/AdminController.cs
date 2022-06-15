using agrokorm.Models;
using agrokorm.Models.Form;
using agrokorm.Models.Products;
using agrokorm.Repository;
using agrokorm.Repository.Interfaces;
using agrokorm.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using agrokorm.Models.Products.Configurations;

namespace agrokorm.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGlobalRepository _repository;
        private readonly IMembraneService _membraneService;
        private readonly ISeedService _seedService;

        //public AdminController(IMembraneService membrservice) { _membraneService = membrservice; }
        public AdminController(IGlobalRepository repo, IMembraneService membrservice, ISeedService seedService) 
        { 
            _repository = repo;
            _membraneService = membrservice;
            _seedService = seedService;
        }

        // GET: AdminController
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MembraneConfiguration(int id)
        {
            var MembraneConfiguration = _repository.GetMembraneConfigurationTable();
            var result = new List<MembraneConfiguration>();

            foreach(var config in MembraneConfiguration)
            {
                if(config.MembraneId == id) result.Add(config);
            }

            return View(result);
        } 

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var Seeds = _repository.GetSeedTable();
                
                var Membranes = _repository.GetMembraneTable();
                var MembraneConfiguration = _repository.GetMembraneConfigurationTable();

                var ViewModelForForms = new FormViewModel();
                

                ViewBag.Seeds = Seeds;
                ViewBag.Membranes = Membranes;
                ViewBag.MembraneConfiguration = MembraneConfiguration;

                var formPrice = new PriceChangingFormModel();

                

                return View("AdminPanel", ViewModelForForms);
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

        [HttpPost]
        public IActionResult CreateNewMembrane(Membrane membraneEntity)
        {
            if (ModelState.IsValid)
            {
                var IsCreated = _membraneService.CreateNewEntity(membraneEntity);

                ViewBag.Error = IsCreated.Description;

                return View("SuccessOrFailure", IsCreated.Data);
            }
            return View("SuccessOrFailure", false);
        }






        [HttpPost]
        public IActionResult CreateNewSeed(Seed seedEntity)
        {
            if (ModelState.IsValid)
            {
                var IsCreated = _seedService.CreateNewEntity(seedEntity);

                ViewBag.Error = IsCreated.Description;

                return View("SuccessOrFailure", IsCreated.Data);

            }
            return View("SuccessOrFailure", false);
        }
        
    }
}
