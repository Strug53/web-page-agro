using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces
{
    public interface IBaseRepository<T, Configuration>
    {
        public bool Create(int id);

        public bool Delete(int id);

        public List<T> SelectAll();

        public T Select(int id);

        public List<Configuration> GetConfigurations();

        public List<Configuration> GetConfigurationsByFK(int id);
    }
}
