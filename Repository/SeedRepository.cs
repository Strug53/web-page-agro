using agrokorm.Models.Db;
using agrokorm.Models.Products;
using agrokorm.Repository.Interfaces.SeedsInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace agrokorm.Repository
{
    public class SeedRepository : ISeedRepository
    {
        private readonly ProductContext _db;

        public SeedRepository(ProductContext db) => _db = db;

        public bool ChangeSunflowerPrice(int id, string Price)
        {
            SunflowerSeed product = SelectSunflower(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeSunflowerTitle(int id, string Title)
        {
            SunflowerSeed product = SelectSunflower(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeVisibleModeOfSunflower(int id)
        {

            SunflowerSeed seed = SelectSunflower(id);

            if (seed.IsVisible)
            {
                seed.IsVisible = false;
                _db.SaveChanges();
                return true;
            }
            else
            {
                seed.IsVisible = true;
                _db.SaveChanges();
                return true;
            }


        }

        public bool CreateSunflower(SunflowerSeed entity)
        {
            _db.SunflowerSeeds.Add(entity);
            _db.SaveChanges();  
            return true;
        }           

        public SunflowerSeed SelectSunflower(int id)
        {
            SunflowerSeed seed = _db.SunflowerSeeds.SingleOrDefault(x => x.Id == id);
            return seed;
        }

        public List<SunflowerSeed> SelectAllSunflower()
        {
            return _db.SunflowerSeeds.ToList();
        }

        public bool DeleteSunflower(int id)
        {
            var item = SelectSunflower(id);
            _db.SunflowerSeeds.Remove(item);
            _db.SaveChanges();
            return true;
        }

        //----- SpringSeed -------

        public bool CreateSpringSeed(SpringSeed entity)
        {
            _db.SpringSeeds.Add(entity);
            _db.SaveChanges();
            return true;
        }

        public List<SpringSeed> SelectAllSpringSeeds()
        {
            return _db.SpringSeeds.ToList();
        }

        public SpringSeed SelectSpringSeed(int id)
        {
            return _db.SpringSeeds.SingleOrDefault(x => x.Id == id);
        }

        public bool ChangeVisibleModeOfSpringSeed(int id)
        {
            SpringSeed seed = SelectSpringSeed(id);

            if (seed.IsVisible)
            {
                seed.IsVisible = false;
                _db.SaveChanges();
                return true;
            }
            else
            {
                seed.IsVisible = true;
                _db.SaveChanges();
                return true;
            }
        }

        public bool ChangeSpringSeedPrice(int id, string Price)
        {
            SpringSeed product = SelectSpringSeed(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeSpringSeedTitle(int id, string Title)
        {
            SpringSeed product = SelectSpringSeed(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }

        public bool DeleteSpringSeed(int id)
        {
            var item = SelectSpringSeed(id);
            _db.SpringSeeds.Remove(item);
            _db.SaveChanges();
            return true;
        }

        //------ Legumes -------
        public bool CreateLegumes(Legumes entity)
        {
            _db.Legumes.Add(entity);
            _db.SaveChanges();
            return true;
        }

        public List<Legumes> SelectAllLegumes()
        {
            return _db.Legumes.ToList();
        }

        public Legumes SelectLegume(int id)
        {
            return _db.Legumes.SingleOrDefault(x => x.Id == id);
        }

        public bool ChangeVisibleModeOfLegume(int id)
        {
            Legumes seed = SelectLegume(id);

            if (seed.IsVisible)
            {
                seed.IsVisible = false;
                _db.SaveChanges();
                return true;
            }
            else
            {
                seed.IsVisible = true;
                _db.SaveChanges();
                return true;
            }
        }

        public bool ChangeLegumePrice(int id, string Price)
        {
            Legumes product = SelectLegume(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeLegumeTitle(int id, string Title)
        {
            Legumes product = SelectLegume(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }

        public bool DeleteLegume(int id)
        {
            var item = SelectLegume(id);
            _db.Legumes.Remove(item);
            _db.SaveChanges();
            return true;
        }

        //-------- Grass Seeds ---------
        public bool CreateGrassSeed(GrassSeed entity)
        {
            _db.GrassSeeds.Add(entity);
            _db.SaveChanges();
            return true;
        }

        public List<GrassSeed> SelectAllGrassSeeds()
        {
            return _db.GrassSeeds.ToList();
        }

        public GrassSeed SelectGrassSeed(int id)
        {
            return _db.GrassSeeds.SingleOrDefault(x => x.Id == id);
        }

        public bool ChangeVisibleModeOfGrassSeed(int id)
        {
            GrassSeed seed = SelectGrassSeed(id);

            if (seed.IsVisible)
            {
                seed.IsVisible = false;
                _db.SaveChanges();
                return true;
            }
            else
            {
                seed.IsVisible = true;
                _db.SaveChanges();
                return true;
            }
        }

        public bool ChangeGrassSeedPrice(int id, string Price)
        {
            GrassSeed product = SelectGrassSeed(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeGrassSeedTitle(int id, string Title)
        {
            GrassSeed product = SelectGrassSeed(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }
        public bool DeleteGrassSeed(int id)
        {
            var item = SelectGrassSeed(id);
            _db.GrassSeeds.Remove(item);
            _db.SaveChanges();
            return true;
        }
    }
}
