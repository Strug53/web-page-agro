using agrokorm.Models.Db;
using agrokorm.Models.Products;
using agrokorm.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace agrokorm.Repository
{
    public class SeedRepository : ISeedRepository
    {
        private readonly ProductContext _db;

        public SeedRepository(ProductContext db) => _db = db;

        public bool ChangePrice(int id, string Price)
        {
            SunflowerSeed product = Select(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeTitle(int id, string Title)
        {
            SunflowerSeed product = Select(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeVisibleMode(int id)
        {

            SunflowerSeed seed = Select(id);
            
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

        public bool Create(SunflowerSeed entity)
        {
            _db.SunflowerSeeds.Add(entity);
            _db.SaveChanges();  
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }


        public SunflowerSeed Select(int id)
        {
            SunflowerSeed seed = _db.SunflowerSeeds.SingleOrDefault(x => x.Id == id);
            return seed;
        }

        public List<SunflowerSeed> SelectAll()
        {
            return _db.SunflowerSeeds.ToList();
        }
    }
}
