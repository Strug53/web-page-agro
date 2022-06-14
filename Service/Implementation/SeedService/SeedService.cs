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
    public class SeedService : IBaseProductService<Seed>
    {

        private readonly ISeedRepository _repository;
        public SeedService(ISeedRepository repo) => _repository = repo;

        public BaseResponse<bool> CreateNewEntity(Seed production)
        {
            try
            {
                var product = _repository.Create(production);
                return new BaseResponse<bool> { Data = true, Description = "Ok", StatusCode = Status.Ok };
            }
            catch(Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message, StatusCode = Status.DatabaseError };
            }
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
