using agrokorm.Models.Db;
using agrokorm.Models.Enum;
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
    public class SeedService : ISeedService
    {

        private readonly ISeedRepository _repository;
        public SeedService(ISeedRepository repo) => _repository = repo;

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

        public BaseResponse<bool> CreateNewEntity(Seed production)
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

        public BaseResponse<List<Seed>> GetAllProduct()
        {
            try
            {
                return new BaseResponse<List<Seed>>() { Data = _repository.SelectAll(), Description = "Ok" };
            }
            catch (Exception ex) { return new BaseResponse<List<Seed>>() { Data = null, Description = ex.Message }; };
        }

        public BaseResponse<Seed> GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
