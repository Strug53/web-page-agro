﻿using agrokorm.Models.Products;
using agrokorm.Service.Response;

namespace agrokorm.Service.Interfaces
{
    public interface ISzrService : IBaseProductService<Szr>
    {
        public BaseResponse<bool> ChangePrice(int id, string Price);
        public BaseResponse<bool> ChangeTitle(int id, string Title);
        public BaseResponse<bool> Delete(int id);
    }
}
