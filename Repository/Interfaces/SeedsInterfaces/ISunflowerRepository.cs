using agrokorm.Models.Products;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces.SeedsInterfaces
{
    public interface ISunflowerRepository
    {
        public bool CreateSunflower(SunflowerSeed entity);

        public bool ChangeSunflowerPrice(int id, string Price);

        public bool ChangeSunflowerTitle(int id, string Price);

        public SunflowerSeed SelectSunflower(int id);

        public List<SunflowerSeed> SelectAllSunflower();

        public bool ChangeVisibleModeOfSunflower(int id);

        bool DeleteSunflower(int id);

    }
}
