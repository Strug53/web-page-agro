using agrokorm.Service.Response;
using System.Collections.Generic;

namespace agrokorm.Service.Interfaces
{
    public interface IBaseProductService<Production, Configuration>
    {
        public BaseResponse<Production> GetProduct(int id);

        public BaseResponse<List<Production>> GetAllProduct();

        public BaseResponse<List<Configuration>> GetAllConfiguration();

        public BaseResponse<List<Configuration>> GetAllConfigurationByForeignKey(int id);

    }
}
