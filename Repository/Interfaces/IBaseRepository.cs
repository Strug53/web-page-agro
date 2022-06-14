using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        public bool Create(T entity);

        public bool Delete(int id);

        public List<T> SelectAll();

        public T Select(int id);

      
    }
}
