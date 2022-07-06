using agrokorm.Models.Products;
using agrokorm.Service.Response;
using System.Collections.Generic;

namespace agrokorm.Service.Interfaces
{
    public interface ISeedService
    {
        public BaseResponse<SunflowerSeed> GetSunflower(int id);
        public BaseResponse<List<SunflowerSeed>> GetAllSunflowers();
        public BaseResponse<bool> CreateNewSunflowerEntity(SunflowerSeed production);
        public BaseResponse<bool> ChangeVisibleModeOfSunflower(int id);
        public BaseResponse<bool> ChangeSunflowerPrice(int id, string Price);
        public BaseResponse<bool> ChangeSunflowerTitle(int id, string Title);



        public BaseResponse<SpringSeed> GetSpringSeed(int id);
        public BaseResponse<List<SpringSeed>> GetAllSpringSeeds();
        public BaseResponse<bool> CreateNewSpringSeedEntity(SpringSeed production);
        public BaseResponse<bool> ChangeVisibleModeOfSpringSeed(int id);
        public BaseResponse<bool> ChangeSpringSeedPrice(int id, string Price);
        public BaseResponse<bool> ChangeSpringSeedTitle(int id, string Title);


    }
}
