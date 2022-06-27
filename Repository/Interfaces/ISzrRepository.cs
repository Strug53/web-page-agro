using agrokorm.Models.Products;

namespace agrokorm.Repository.Interfaces
{
    public interface ISzrRepository : IBaseRepository<Szr>
    {
        bool ChangePrice(int id, string Price);
        bool ChangeTitle(int id, string Title);
    }
}
