using agrokorm.Models.Db;
using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using agrokorm.Repository.Interfaces;
using System.Collections.Generic;

using System.Linq;

namespace agrokorm.Repository
{
    public class MembraneRepository : IMembraneRepository
    {
        private readonly ProductContext _db;

        public MembraneRepository(ProductContext db) { _db = db; }

        public bool ChangeDescription(int id, string Description)
        {
            Membrane product = Select(id);
            product.Description = Description;
            _db.SaveChanges();
            return true;
        }

        public bool ChangePrice(int id, string Price)
        {
            Membrane product = Select(id);
            product.Price = Price;
            _db.SaveChanges();
            return true;
        }

        public bool ChangeTitle(int id, string Title)
        {
            Membrane product = Select(id);
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

        public bool Create(Membrane membrane)
        {
            _db.Membranes.Add(membrane);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var item = Select(id);
            _db.Membranes.Remove(item);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteMembraneConfiguration(int id)
        {
            var item = SelectConfiguration(id);
            _db.MembraneConfigurations.Remove(item);
            _db.SaveChanges();
            return true;
        }
        public MembraneConfiguration SelectConfiguration(int id)
        {
            return _db.MembraneConfigurations.FirstOrDefault(c => c.Id == id);
        } 
        public List<MembraneConfiguration> GetConfigurations()
        {
            var allConfiguration = _db.MembraneConfigurations.ToList();
            return allConfiguration;
        }

        public List<MembraneConfiguration> GetConfigurationsByFK(int id)
        {
            var items = _db.MembraneConfigurations.Where(x => x.MembraneId == id).ToList();
            return items;
        }

        public Membrane Select(int id)
        {
            Membrane membrane = _db.Membranes.SingleOrDefault(x => x.Id == id);
            return membrane;
        }

        public List<Membrane> SelectAll()
        {
            var allItems = _db.Membranes.ToList();
            return allItems;
        }

        public bool CreateNewMembraneConfiguration(MembraneConfiguration config)
        {
            _db.MembraneConfigurations.Add(config);
            _db.SaveChanges();
            return true;
        }
        public bool ChangeVisibleModeOfMembraneConfiguration(int id)
        {
            var membrane = SelectConfiguration(id);
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
        
    }
}
