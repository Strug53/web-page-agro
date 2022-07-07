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

        //---- Spring Seed -----

        public BaseResponse<SpringSeed> GetSpringSeed(int id);
        public BaseResponse<List<SpringSeed>> GetAllSpringSeeds();
        public BaseResponse<bool> CreateNewSpringSeedEntity(SpringSeed production);
        public BaseResponse<bool> ChangeVisibleModeOfSpringSeed(int id);
        public BaseResponse<bool> ChangeSpringSeedPrice(int id, string Price);
        public BaseResponse<bool> ChangeSpringSeedTitle(int id, string Title);


        //---- Legumes -------

        public BaseResponse<Legumes> GetLegume(int id);
        public BaseResponse<List<Legumes>> GetAllLegumes();
        public BaseResponse<bool> CreateNewLegumeEntity(Legumes production);
        public BaseResponse<bool> ChangeVisibleModeOfLegume(int id);
        public BaseResponse<bool> ChangeLegumePrice(int id, string Price);
        public BaseResponse<bool> ChangeLegumeTitle(int id, string Title);


        //----- Grass Seed --------

        public BaseResponse<GrassSeed> GetGrassSeed(int id);
        public BaseResponse<List<GrassSeed>> GetAllGrassSeeds();
        public BaseResponse<bool> CreateNewGrassSeedEntity(GrassSeed production);
        public BaseResponse<bool> ChangeVisibleModeOfGrassSeed(int id);
        public BaseResponse<bool> ChangeGrassSeedPrice(int id, string Price);
        public BaseResponse<bool> ChangeGrassSeedTitle(int id, string Title);


    }
}
