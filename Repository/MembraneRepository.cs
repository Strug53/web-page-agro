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

        public bool Create(Membrane membrane)
        {
            _db.Membranes.Add(membrane);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
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
        
    }
}
