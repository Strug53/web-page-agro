using agrokorm.Models.Products;

namespace agrokorm.Repository.Interfaces
{
    public interface ISeedRepository : IBaseRepository<Seed>
    {
        bool ChangePrice(int id, string Price);
        bool ChangeTitle(int id, string Title);


    }
}
