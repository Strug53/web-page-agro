using agrokorm.Models.Enum;

namespace agrokorm.Service.Response
{
    public class BaseResponse <T>
    {
        public string Description { get; set; }
        public Status StatusCode { get; set; }
        public T Data { get; set; }
    }
}
