using agrokorm.Models.Products;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces.SeedsInterfaces
{
    public interface ISpringSeedRepository
    {
        public bool CreateSpringSeed(SpringSeed entity);

        public List<SpringSeed> SelectAllSpringSeeds();

        public SpringSeed SelectSpringSeed(int id);

        public bool ChangeVisibleModeOfSpringSeed(int id);
        bool ChangeSpringSeedPrice(int id, string Price);

        bool ChangeSpringSeedTitle(int id, string Title);

    }
}
