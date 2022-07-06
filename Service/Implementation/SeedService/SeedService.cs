using agrokorm.Models.Db;

using agrokorm.Models.Products;
using agrokorm.Repository;
using agrokorm.Repository.Interfaces.SeedsInterfaces;
using agrokorm.Service.Interfaces;
using agrokorm.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;


namespace agrokorm.Service.Implementation.SeedService
{
    public class SeedService : ISeedService
    {

        private readonly ISeedRepository _repository;
        public SeedService(ISeedRepository repo) => _repository = repo;

        

        public BaseResponse<bool> ChangeSunflowerPrice(int id, string Price)
        {
            try
            {
                var IsChanged = _repository.ChangeSunflowerPrice(id, Price);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok"};
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        public BaseResponse<bool> ChangeSunflowerTitle(int id, string Title)
        {
            try
            {
                bool IsChanged = _repository.ChangeSunflowerTitle(id, Title);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        

        public BaseResponse<bool> ChangeVisibleModeOfSunflower(int id)
        {
            try
            {
                var IsChanged = _repository.ChangeVisibleModeOfSunflower(id);
                if (IsChanged)
                {
                    return new BaseResponse<bool> { Data = true, Description = "Ok" };
                }
                else { return new BaseResponse<bool> { Data = false, Description = "Error" }; }
            }
            catch(Exception ex) { return new BaseResponse<bool> { Data = false, Description=ex.Message }; }
        }

        

        public BaseResponse<bool> CreateNewSunflowerEntity(SunflowerSeed production)
        {
            try
            {
                var IsCreated = _repository.CreateSunflower(production);
                return new BaseResponse<bool> { Data = IsCreated, Description = "Ok"};
            }
            catch(Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        

        public BaseResponse<List<SunflowerSeed>> GetAllSunflowers()
        {
            try
            {
                return new BaseResponse<List<SunflowerSeed>>() { Data = _repository.SelectAllSunflower(), Description = "Ok" };
            }
            catch (Exception ex) { return new BaseResponse<List<SunflowerSeed>>() { Data = null, Description = ex.Message }; };
        }

        

        public BaseResponse<SunflowerSeed> GetSunflower(int id)
        {
            try
            {
                var seed = _repository.SelectSunflower(id);
                return new BaseResponse<SunflowerSeed> { Data = seed, Description = "Ok" };
            }
            catch(Exception ex) { return new BaseResponse<SunflowerSeed> { Data = null, Description = ex.Message }; }
        }

        // ----------- Spring Seed --------------

        public BaseResponse<SpringSeed> GetSpringSeed(int id)
        {
            try
            {
                var seed = _repository.SelectSpringSeed(id);
                return new BaseResponse<SpringSeed> { Data = seed, Description = "Ok" };
            }
            catch (Exception ex) { return new BaseResponse<SpringSeed> { Data = null, Description = ex.Message }; }
        }


        public BaseResponse<List<SpringSeed>> GetAllSpringSeeds()
        {
            try
            {
                return new BaseResponse<List<SpringSeed>>() { Data = _repository.SelectAllSpringSeeds(), Description = "Ok" };
            }
            catch (Exception ex) { return new BaseResponse<List<SpringSeed>>() { Data = null, Description = ex.Message }; };
        }


        public BaseResponse<bool> CreateNewSpringSeedEntity(SpringSeed production)
        {
            try
            {
                var IsCreated = _repository.CreateSpringSeed(production);
                return new BaseResponse<bool> { Data = IsCreated, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }


        public BaseResponse<bool> ChangeVisibleModeOfSpringSeed(int id)
        {
            try
            {
                var IsChanged = _repository.ChangeVisibleModeOfSpringSeed(id);
                if (IsChanged)
                {
                    return new BaseResponse<bool> { Data = true, Description = "Ok" };
                }
                else { return new BaseResponse<bool> { Data = false, Description = "Error" }; }
            }
            catch (Exception ex) { return new BaseResponse<bool> { Data = false, Description = ex.Message }; }
        }
        public BaseResponse<bool> ChangeSpringSeedPrice(int id, string Price)
        {
            try
            {
                var IsChanged = _repository.ChangeSpringSeedPrice(id, Price);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        public BaseResponse<bool> ChangeSpringSeedTitle(int id, string Title)
        {
            try
            {
                var IsChanged = _repository.ChangeSpringSeedPrice(id, Title);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

    }
}
