using agrokorm.Models.Db;

using agrokorm.Models.Products;
using agrokorm.Repository;
using agrokorm.Repository.Interfaces;
using agrokorm.Service.Interfaces;
using agrokorm.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;


namespace agrokorm.Service.Implementation.SeedService
{
    public class SunflowerSeedService : ISunflowerSeedService
    {

        private readonly ISeedRepository _repository;
        public SunflowerSeedService(ISeedRepository repo) => _repository = repo;

        public BaseResponse<bool> ChangePrice(int id, string Price)
        {
            try
            {
                var IsChanged = _repository.ChangePrice(id, Price);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok"};
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        public BaseResponse<bool> ChangeTitle(int id, string Title)
        {
            try
            {
                bool IsChanged = _repository.ChangeTitle(id, Title);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        public BaseResponse<bool> ChangeVisibleMode(int id)
        {
            try
            {
                var IsChanged = _repository.ChangeVisibleMode(id);
                if (IsChanged)
                {
                    return new BaseResponse<bool> { Data = true, Description = "Ok" };
                }
                else { return new BaseResponse<bool> { Data = false, Description = "Error" }; }
            }
            catch(Exception ex) { return new BaseResponse<bool> { Data = false, Description=ex.Message }; }
        }

        public BaseResponse<bool> CreateNewEntity(SunflowerSeed production)
        {
            try
            {
                var IsCreated = _repository.Create(production);
                return new BaseResponse<bool> { Data = IsCreated, Description = "Ok"};
            }
            catch(Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        public BaseResponse<List<SunflowerSeed>> GetAllProduct()
        {
            try
            {
                return new BaseResponse<List<SunflowerSeed>>() { Data = _repository.SelectAll(), Description = "Ok" };
            }
            catch (Exception ex) { return new BaseResponse<List<SunflowerSeed>>() { Data = null, Description = ex.Message }; };
        }

        public BaseResponse<SunflowerSeed> GetProduct(int id)
        {
            try
            {
                var seed = _repository.Select(id);
                return new BaseResponse<SunflowerSeed> { Data = seed, Description = "Ok" };
            }
            catch(Exception ex) { return new BaseResponse<SunflowerSeed> { Data = null, Description = ex.Message }; }
        }
    }
}
