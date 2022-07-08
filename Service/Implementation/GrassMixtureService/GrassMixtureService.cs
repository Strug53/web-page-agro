using agrokorm.Models.Products;
using agrokorm.Repository.Interfaces;
using agrokorm.Service.Interfaces;
using agrokorm.Service.Response;
using System;
using System.Collections.Generic;

namespace agrokorm.Service.Implementation.GrassMixtureService
{
    public class GrassMixtureService : IGrassMixtrueService
    {
        private readonly IGrassMixtureRepository _repository;
        public GrassMixtureService(IGrassMixtureRepository repo) => _repository = repo;

        public BaseResponse<bool> ChangeDescription(int id, string Description)
        {
            try
            {
                var IsChanged = _repository.ChangeDescription(id, Description);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        public BaseResponse<bool> ChangePrice(int id, string Price)
        {
            try
            {
                var IsChanged = _repository.ChangePrice(id, Price);
                return new BaseResponse<bool> { Data = IsChanged, Description = "Ok" };
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
            catch (Exception ex) { return new BaseResponse<bool> { Data = false, Description = ex.Message }; }
        }

        public BaseResponse<bool> CreateNewEntity(GrassMixture production)
        {
            try
            {
                var IsCreated = _repository.Create(production);
                return new BaseResponse<bool> { Data = IsCreated, Description = "Ok" };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description = ex.Message };
            }
        }

        public BaseResponse<bool> Delete(int id)
        {
            try
            {
                var IsDelete = _repository.Delete(id);
                return new BaseResponse<bool> { Data = IsDelete, Description = "Ok" };
            }
            catch(Exception ex)
            {
                return new BaseResponse<bool> { Data = false, Description=ex.Message};
            }
        }

        public BaseResponse<List<GrassMixture>> GetAllProduct()
        {
            try
            {
                return new BaseResponse<List<GrassMixture>>() { Data = _repository.SelectAll(), Description = "Ok" };
            }
            catch (Exception ex) { return new BaseResponse<List<GrassMixture>>() { Data = null, Description = ex.Message }; };
        }

        public BaseResponse<GrassMixture> GetProduct(int id)
        {
            try
            {
                var szr = _repository.Select(id);
                return new BaseResponse<GrassMixture> { Data = szr, Description = "Ok" };
            }
            catch (Exception ex) { return new BaseResponse<GrassMixture> { Data = null, Description = ex.Message }; }
        }
    }
}
