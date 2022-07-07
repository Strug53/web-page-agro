using System.ComponentModel.DataAnnotations;

namespace agrokorm.Models.Products
{
    public class SpringSeed
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public string Category { get; set; }

        public bool IsVisible { get; set; }
    }
}
