using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using agrokorm.Service.Response;
using System.Collections.Generic;

namespace agrokorm.Service.Interfaces
{
    public interface IMembraneService : IBaseProductService<Membrane>
    {
        public BaseResponse<List<MembraneConfiguration>> GetAllConfigurationByForeignKey(int id);

        public BaseResponse<List<MembraneConfiguration>> GetAllConfiguration();

        public BaseResponse<bool> ChangePrice(int id, string Price);

        public BaseResponse<bool> ChangeTitle(int id, string Title);
        public BaseResponse<bool> ChangeDescription(int id, string Description);

        public BaseResponse<bool> Delete(int id);
        public BaseResponse<bool> DeleteConfiguration(int id);

        

        public BaseResponse<bool> CreateNewMembraneConfiguration(MembraneConfiguration config);





    }
}
