using agrokorm.Models.Products;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces.SeedsInterfaces
{
    public interface IGrassSeedRepository
    {

        public bool CreateGrassSeed(GrassSeed entity);

        public List<GrassSeed> SelectAllGrassSeeds();

        public GrassSeed SelectGrassSeed(int id);

        public bool ChangeVisibleModeOfGrassSeed(int id);

        bool ChangeGrassSeedPrice(int id, string Price);

        bool ChangeGrassSeedTitle(int id, string Title);

    }
}
