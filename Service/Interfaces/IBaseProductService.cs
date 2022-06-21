using agrokorm.Models.Products.Configurations;
using agrokorm.Service.Response;
using System.Collections.Generic;

namespace agrokorm.Service.Interfaces
{
    public interface IBaseProductService<Production>
    {
        public BaseResponse<Production> GetProduct(int id);

        public BaseResponse<List<Production>> GetAllProduct();

        public BaseResponse<bool> CreateNewEntity(Production production);

        public BaseResponse<bool> ChangeVisibleMode(int id);

    }
}
