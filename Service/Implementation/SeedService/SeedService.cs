using agrokorm.Models.Db;
using agrokorm.Models.Enum;
using agrokorm.Models.Products;
using agrokorm.Models.Products.Configurations;
using agrokorm.Repository;
using agrokorm.Repository.Interfaces;
using agrokorm.Service.Interfaces;
using agrokorm.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;


namespace agrokorm.Service.Implementation.SeedService
{
    public class SeedService : IBaseProductService<Seed, SeedConfiguration>
    {

        private readonly ISeedRepository _repository;
        public SeedService(ISeedRepository repo) => _repository = repo;

        public BaseResponse<List<SeedConfiguration>> GetAllConfiguration()
        {
            try
            {
                return new BaseResponse<List<SeedConfiguration>>() { Data = _repository.GetConfigurations(), Description = "Ok", StatusCode = Status.Ok };
            }
            catch (Exception ex) { return new BaseResponse<List<SeedConfiguration>>() { Data = null, Description = ex.Message, StatusCode = Status.DatabaseError }; };
        }

        public BaseResponse<List<SeedConfiguration>> GetAllConfigurationByForeignKey(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<List<Seed>> GetAllProduct()
        {
            try
            {
                return new BaseResponse<List<Seed>>() { Data = _repository.SelectAll(), Description = "Ok", StatusCode = Status.Ok };
            }
            catch (Exception ex) { return new BaseResponse<List<Seed>>() { Data = null, Description = ex.Message, StatusCode = Status.DatabaseError }; };
        }

        public BaseResponse<Seed> GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
