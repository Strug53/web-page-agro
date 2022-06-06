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

namespace agrokorm.Service.ProductServices.MembraneService
{
    public class MembraneService : IMembraneService
    {
        private readonly IMembraneRepository repository;

        public MembraneService(IMembraneRepository repo) { repository = repo; }

        public BaseResponse<List<Membrane>> GetAllProduct()
        {
            try
            {
                var allItems = repository.SelectAll();
                var response = new BaseResponse<List<Membrane>>() { Data = allItems, Description="Ok", StatusCode = Status.Ok };
                return response;
                
            }
            catch(Exception ex)
            {
                var errorResponse = new BaseResponse<List<Membrane>>() { Data = null, StatusCode = Status.Ok, Description="Ошибка в получении данных из БД"};
                return errorResponse;
            }
        }

        public BaseResponse<Membrane> GetProduct(int id)
        {
            try 
            { 
                var data = repository.Select(id);
                return new BaseResponse<Membrane>() { Data = data, Description="Ok", StatusCode= Status.Ok } ;
            }
            catch(Exception ex) { return new BaseResponse<Membrane>() { Data = null, StatusCode = Status.DatabaseError, Description = "Ошибка в получении данных из БД" }; }
        }

        public BaseResponse<List<MembraneConfiguration>> GetAllConfiguration()
        {
            try
            {
                var configurations = repository.GetConfigurations();
                return new BaseResponse<List<MembraneConfiguration>>() { Data = configurations, Description = "Ok", StatusCode = Status.Ok };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<MembraneConfiguration>>() { Data = null, Description = "Ощибка в получении данных из БД", StatusCode = Status.Ok };
            }
        }

        public BaseResponse<List<MembraneConfiguration>> GetAllConfigurationByForeignKey(int id)
        {
            try
            {
                var items = repository.GetConfigurationsByFK(id);
                return new BaseResponse<List<MembraneConfiguration>> { Data = items, Description = "Ok", StatusCode = Status.Ok };
            }
            catch(Exception ex) { return new BaseResponse<List<MembraneConfiguration>> { Data = null, Description = ex.Message, StatusCode = Status.DatabaseError }; }
        }
    }
}
