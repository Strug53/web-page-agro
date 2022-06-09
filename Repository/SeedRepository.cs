using agrokorm.Models.Db;
using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using agrokorm.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace agrokorm.Repository
{
    public class SeedRepository : IBaseRepository<Seed, SeedConfiguration>
    {
        private readonly ProductContext _db;

        public SeedRepository(ProductContext db) => _db = db;

        public bool Create(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<SeedConfiguration> GetConfigurations()
        {
            return _db.SeedConfigurations.ToList();
        }

        public List<SeedConfiguration> GetConfigurationsByFK(int id)
        {
            throw new System.NotImplementedException();
        }

        public Seed Select(int id)
        {
            throw new System.NotImplementedException();

        }

        public List<Seed> SelectAll()
        {
            return _db.Seeds.ToList();
        }
    }
}
