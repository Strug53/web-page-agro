using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces
{
    public interface IMembraneRepository : IBaseRepository<Membrane>
    {
        List<MembraneConfiguration> GetConfigurations();
        List<MembraneConfiguration> GetConfigurationsByFK(int id);
        bool ChangePrice(int id, string Price);
    }
}
