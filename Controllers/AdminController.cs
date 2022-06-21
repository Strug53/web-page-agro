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
        private readonly ISunflowerSeedService _seedService;

        //public AdminController(IMembraneService membrservice) { _membraneService = membrservice; }
        public AdminController(IGlobalRepository repo, IMembraneService membrservice, ISunflowerSeedService seedService) 
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

        //changing
        [HttpPost]
        public IActionResult SubmitNewPrice(PriceChangingFormModel form)
        {
            if (ModelState.IsValid)
            {
                bool IsOk;
                switch (form.Table)
                {
                    case "Membrane":
                        var MembraneIsChanged = _membraneService.ChangePrice(form.Id, form.Price);
                        IsOk = MembraneIsChanged.Data;
                        break;
                    case "Seed":
                        var SeedIsChanged = _seedService.ChangePrice(form.Id, form.Price);
                        IsOk = SeedIsChanged.Data;
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
        public IActionResult SubmitNewTitle(TitleAndDescriptionChangingFormModel form)
        {
            if (ModelState.IsValid)
            {
                bool IsOk;
                switch (form.Table)
                {
                    case "Membrane":
                        var MembraneIsChanged = _membraneService.ChangeTitle(form.Id, form.TitleOrDescription);
                        IsOk = MembraneIsChanged.Data;
                        break;
                    case "Seed":
                        var SeedIsChanged = _seedService.ChangeTitle(form.Id, form.TitleOrDescription);
                        IsOk = SeedIsChanged.Data;
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
        public IActionResult SubmitNewDescription(TitleAndDescriptionChangingFormModel form)
        {
            if (ModelState.IsValid)
            {
                bool IsOk;
                switch (form.Table)
                {
                    case "Membrane":
                        var MembraneIsChanged = _membraneService.ChangeDescription(form.Id, form.TitleOrDescription);
                        IsOk = MembraneIsChanged.Data;
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

        
        public IActionResult ChangeVisibleModeInSeedTable(int id)
        {
            var IsChanged = _seedService.ChangeVisibleMode(id);

            return View("SuccessOrFailure", IsChanged.Data);
        }
        public IActionResult ChangeVisibleModeInMembraneTable(int id)
        {
            var IsChanged = _membraneService.ChangeVisibleMode(id);

            return View("SuccessOrFailure", IsChanged.Data);
        }

        //Creating new items
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
        public IActionResult CreateNewSeed(SunflowerSeed seedEntity)
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
