using agrokorm.Models.Db;
using agrokorm.Models.Products;
using agrokorm.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace agrokorm.Repository
{
    public class SzrRepository : ISzrRepository
    {
        private readonly ProductContext _db;

        public SzrRepository(ProductContext db)
        {
            _db = db;
        }

        public bool ChangePrice(int id, string Price)
        {
            Szr product = Select(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeTitle(int id, string Title)
        {
            Szr product = Select(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeVisibleMode(int id)
        {
            Szr product = Select(id);

            if (product.IsVisible)
            {
                product.IsVisible = false;
                _db.SaveChanges();
                return true;
            }
            else
            {
                product.IsVisible = true;
                _db.SaveChanges();
                return true;
            }
        }

        public bool Create(Szr entity)
        {
            _db.Szrs.Add(entity);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Szr Select(int id)
        {
            Szr szr = _db.Szrs.SingleOrDefault(x => x.Id == id);
            return szr;
        }

        public List<Szr> SelectAll()
        {
            return _db.Szrs.ToList();
        }
    }
}
