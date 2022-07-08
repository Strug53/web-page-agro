using agrokorm.Models.Products;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces
{
    public interface IGrassMixtureRepository
    {
        public bool Create(GrassMixture entity);

        public List<GrassMixture> SelectAll();

        public GrassMixture Select(int id);

        public bool ChangeVisibleMode(int id);

        bool ChangePrice(int id, string Price);

        bool ChangeTitle(int id, string Title);

        bool ChangeDescription(int id, string Description);

        bool Delete(int id);
    }
}
