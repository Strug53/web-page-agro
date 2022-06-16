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
            Seed product = Select(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeTitle(int id, string Title)
        {
            Seed product = Select(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }
        public bool Create(Seed entity)
        {
            _db.Seeds.Add(entity);
            _db.SaveChanges();  
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }


        public Seed Select(int id)
        {
            Seed seed = _db.Seeds.SingleOrDefault(x => x.Id == id);
            return seed;
        }

        public List<Seed> SelectAll()
        {
            return _db.Seeds.ToList();
        }
    }
}
