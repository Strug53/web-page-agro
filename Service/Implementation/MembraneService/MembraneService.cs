﻿using agrokorm.Models.Db;
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
                var response = new BaseResponse<List<Membrane>>() { Data = allItems, Description="Ok"};
                return response;
                
            }
            catch(Exception ex)
            {
                var errorResponse = new BaseResponse<List<Membrane>>() { Data = null, Description=ex.Message};
                return errorResponse;
            }
        }

        public BaseResponse<Membrane> GetProduct(int id)
        {
            try 
            { 
                var data = repository.Select(id);
                return new BaseResponse<Membrane>() { Data = data, Description="Ok"} ;
            }
            catch(Exception ex) { return new BaseResponse<Membrane>() { Data = null, Description = ex.Message }; }
        }

        public BaseResponse<List<MembraneConfiguration>> GetAllConfiguration()
        {
            try
            {
                var configurations = repository.GetConfigurations();
                return new BaseResponse<List<MembraneConfiguration>>() { Data = configurations, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<MembraneConfiguration>>() { Data = null, Description = ex.Message};
            }
        }

        public BaseResponse<List<MembraneConfiguration>> GetAllConfigurationByForeignKey(int id)
        {
            try
            {
                var items = repository.GetConfigurationsByFK(id);
                return new BaseResponse<List<MembraneConfiguration>> { Data = items, Description = "Ok" };
            }
            catch(Exception ex) { return new BaseResponse<List<MembraneConfiguration>> { Data = null, Description = ex.Message}; }
        }

        public BaseResponse<bool> ChangePrice(int id, string Price)
        {
            try
            {
                var IsChanged = repository.ChangePrice(id, Price);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok"};
            }
            catch(Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message};
            }

        }

        public BaseResponse<bool> CreateNewEntity(Membrane production)
        {
            try
            {
                bool IsCreated = repository.Create(production);
                return new BaseResponse<bool> { Data = true, Description = "Ok"};
            }
            catch(Exception ex)
            {
                return new BaseResponse<bool> { Data = true, Description = ex.Message };
            }
        }
    }
}
