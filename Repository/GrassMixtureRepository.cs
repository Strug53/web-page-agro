using agrokorm.Models.Db;
using agrokorm.Models.Products;
using agrokorm.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace agrokorm.Repository
{
    public class GrassMixtureRepository : IGrassMixtureRepository
    {
        private readonly ProductContext _db;

        public GrassMixtureRepository(ProductContext db) { _db = db; }

        public bool ChangeDescription(int id, string Description)
        {
            GrassMixture product = Select(id);
            product.Description = Description;
            _db.SaveChanges();
            return true;
        }

        public bool ChangePrice(int id, string Price)
        {
            GrassMixture product = Select(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeTitle(int id, string Title)
        {
            GrassMixture product = Select(id);
            product.Name = Title;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeVisibleMode(int id)
        {
            var membrane = Select(id);
            if (membrane != null)
            {
                if (membrane.IsVisible)
                {
                    membrane.IsVisible = false;
                    _db.SaveChanges();
                    return true;
                }
                else
                {
                    membrane.IsVisible = true;
                    _db.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Create(GrassMixture membrane)
        {
            _db.GrassMixtures.Add(membrane);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {

            var item = Select(id);
            _db.GrassMixtures.Remove(item);
            _db.SaveChanges();
            return true;
        }

       

        public GrassMixture Select(int id)
        {
            GrassMixture membrane = _db.GrassMixtures.SingleOrDefault(x => x.Id == id);
            return membrane;
        }

        public List<GrassMixture> SelectAll()
        {
            var allItems = _db.GrassMixtures.ToList();
            return allItems;
        }

    }
}
