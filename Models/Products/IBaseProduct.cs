
using agrokorm.Models.Enum;

namespace agrokorm.Models.Products
{
    public interface IBaseProduct
    {
        public string Name { get; set; }
        public CategoryEnum Category { get; set; }
    }
}
