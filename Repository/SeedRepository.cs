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
    }
}
