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

        public bool Create(int id)
        {
            throw new System.NotImplementedException();
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
            var items = _db.MembraneConfigurations.ToList().Where(x => x.MembraneId == id);
            return (List<MembraneConfiguration>)items;
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
