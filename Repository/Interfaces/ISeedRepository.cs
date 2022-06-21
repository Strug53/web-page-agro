using agrokorm.Models.Products;

namespace agrokorm.Repository.Interfaces
{
    public interface ISeedRepository : IBaseRepository<SunflowerSeed>
    {
        bool ChangePrice(int id, string Price);
        bool ChangeTitle(int id, string Title);


    }
}
