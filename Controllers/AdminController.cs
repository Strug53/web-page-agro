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
        private readonly ISzrService _szrService;

        

        public AdminController(IGlobalRepository repo, IMembraneService membrservice, ISeedService seedService, ISzrService szr ) 
        {
            _szrService = szr;
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
                if (admin.Password.Equals("123"))
                {
                    
                    return Profile();
                }
                else
                {
                    return View("Error");
                }
            }
            else
            {
                return View("Error");
            }
            
        }
        public IActionResult RedirectToAdmin(int id)
        {
            if (id == 1748925468) return Profile();
            else return NotFound(); 
        }
        private IActionResult Profile()
        {
            var Seeds = _repository.GetSeedTable();

            var Membranes = _repository.GetMembraneTable();
            var MembraneConfiguration = _repository.GetMembraneConfigurationTable();
            var Szrs = _repository.GetSzrTable();
            var SpringSeeds = _seedService.GetAllSpringSeeds().Data;
            var Legumes = _seedService.GetAllLegumes().Data;
            var GrassSeeds = _seedService.GetAllGrassSeeds().Data;

            var ViewModelForForms = new FormViewModel();

            ViewBag.Szrs = Szrs;
            ViewBag.Seeds = Seeds;
            ViewBag.Membranes = Membranes;
            ViewBag.MembraneConfiguration = MembraneConfiguration;
            ViewBag.SpringSeeds = SpringSeeds;
            ViewBag.Legumes = Legumes;
            ViewBag.GrassSeeds = GrassSeeds;

            var formPrice = new PriceChangingFormModel();



            return View("AdminPanel", ViewModelForForms);
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
                    case "Sunflower":
                        var SeedIsChanged = _seedService.ChangeSunflowerPrice(form.Id, form.Price);
                        IsOk = SeedIsChanged.Data;
                        break;
                    case "Szr":
                        var SzrIsChanged = _szrService.ChangePrice(form.Id, form.Price);
                        IsOk = SzrIsChanged.Data;
                        break;

                    case "SpringSeed":
                        var SpringSeedIsChanged = _seedService.ChangeSpringSeedPrice(form.Id, form.Price);
                        IsOk = SpringSeedIsChanged.Data;
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
                    case "Sunflower":
                        var SeedIsChanged = _seedService.ChangeSunflowerTitle(form.Id, form.TitleOrDescription);
                        IsOk = SeedIsChanged.Data;
                        break;

                    case "Szr":
                        var SzrIsChanged = _szrService.ChangeTitle(form.Id, form.TitleOrDescription);
                        IsOk = SzrIsChanged.Data;
                        break;

                    case "SpringSeed":
                        var SpringSeedIsChanged = _seedService.ChangeSpringSeedTitle(form.Id, form.TitleOrDescription);
                        IsOk = SpringSeedIsChanged.Data;
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

        
        public IActionResult ChangeVisibleModeInSunflowerTable(int id)
        {
            var IsChanged = _seedService.ChangeVisibleModeOfSunflower(id);

            return View("SuccessOrFailure", IsChanged.Data);
        }

        public IActionResult ChangeVisibleModeInSpringSeed(int id)
        {
            var IsChanged = _seedService.ChangeVisibleModeOfSpringSeed(id);

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
        public IActionResult CreateNewSunflower(SunflowerSeed seedEntity)
        {
            if (ModelState.IsValid)
            {
                var IsCreated = _seedService.CreateNewSunflowerEntity(seedEntity);

                ViewBag.Error = IsCreated.Description;

                return View("SuccessOrFailure", IsCreated.Data);

            }
            return View("SuccessOrFailure", false);
        }

        [HttpPost]
        public IActionResult CreateNewLegume(Legumes legumeEntity)
        {
            if (ModelState.IsValid)
            {
                var IsCreated = _seedService.CreateNewLegumeEntity(legumeEntity);

                ViewBag.Error = IsCreated.Description;

                return View("SuccessOrFailure", IsCreated.Data);

            }
            return View("SuccessOrFailure", false);
        }

        [HttpPost]
        public IActionResult CreateNewGrassSeed(GrassSeed grassSeedEntity)
        {
            if (ModelState.IsValid)
            {
                var IsCreated = _seedService.CreateNewGrassSeedEntity(grassSeedEntity);

                ViewBag.Error = IsCreated.Description;

                return View("SuccessOrFailure", IsCreated.Data);

            }
            return View("SuccessOrFailure", false);
        }

        [HttpPost]
        public IActionResult CreateNewSzr(Szr szrEntity)
        {
            if (ModelState.IsValid)
            {
                var isCreated = _szrService.CreateNewEntity(szrEntity);
                ViewBag.Error = isCreated.Description;
                return View("SuccessOrFailure", isCreated.Data);
            }
            return View("SuccessOrFailure", false);
        }

        [HttpPost]
        public IActionResult CreateNewSpringSeed(SpringSeed springSeedEntity)
        {
            if (ModelState.IsValid)
            {
                var isCreated = _seedService.CreateNewSpringSeedEntity(springSeedEntity);
                ViewBag.Error = isCreated.Description;
                return View("SuccessOrFailure", isCreated.Data);
            }
            return View("SuccessOrFailure", false);
        }
    }
}
