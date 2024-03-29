﻿using agrokorm.Models.Db;
using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using agrokorm.Repository.Interfaces;
using System.Collections.Generic;

using System.Linq;

namespace agrokorm.Repository
{
    public class GlobalRepository : IGlobalRepository
    {
        private readonly ProductContext _db;

        public GlobalRepository(ProductContext db) { _db = db; }

        public List<SunflowerSeed> GetSeedTable() => _db.SunflowerSeeds.ToList();

        public List<Membrane> GetMembraneTable() => _db.Membranes.ToList();

        public List<MembraneConfiguration> GetMembraneConfigurationTable() => _db.MembraneConfigurations.ToList();

        public List<Szr> GetSzrTable() => _db.Szrs.ToList();
        
    }
}
