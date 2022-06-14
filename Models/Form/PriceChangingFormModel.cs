using System.ComponentModel.DataAnnotations;

namespace agrokorm.Models.Form
{
    public class PriceChangingFormModel : IFormClass
    {
        [Required]
        public string Table { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Price { get; set; }
    }
}
