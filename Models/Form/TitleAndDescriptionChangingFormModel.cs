using System.ComponentModel.DataAnnotations;

namespace agrokorm.Models.Form
{
    public class TitleAndDescriptionChangingFormModel
    {
        [Required]
        public string Table { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string TitleOrDescription { get; set; }
    }
}
