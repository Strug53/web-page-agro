using System.ComponentModel.DataAnnotations;

namespace agrokorm.Models
{
    public class Admin
    {
        [Required(ErrorMessage ="Необходимо ввести пароль")]
        public string Password { get; set; }
    }
}
