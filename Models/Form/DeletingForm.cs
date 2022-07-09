using System.ComponentModel.DataAnnotations;

namespace agrokorm.Models.Form
{
    public class DeletingForm
    {
        [Required]
        public string Table { get; set; }

        [Required]
        public int Id { get; set; }
    }
}
