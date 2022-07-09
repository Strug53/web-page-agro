using agrokorm.Models.Products;
using System.Collections.Generic;

namespace agrokorm.Repository.Interfaces.SeedsInterfaces
{
    public interface ILegumesRepository
    {
        public bool CreateLegumes(Legumes entity);

        public List<Legumes> SelectAllLegumes();

        public Legumes SelectLegume(int id);

        public bool ChangeVisibleModeOfLegume(int id);

        bool ChangeLegumePrice(int id, string Price);

        bool ChangeLegumeTitle(int id, string Title);

        bool DeleteLegume(int id);
    }
}
