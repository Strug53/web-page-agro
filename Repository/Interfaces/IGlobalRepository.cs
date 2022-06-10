﻿using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces
{
    public interface IGlobalRepository
    {
        public List<Seed> GetSeedTable();

        public List<SeedConfiguration> GetSeedConfigurationsTable();

        public List<Membrane> GetMembraneTable();

        public List<MembraneConfiguration> GetMembraneConfigurationTable();
    }
}
