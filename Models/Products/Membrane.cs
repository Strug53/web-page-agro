using agrokorm.Models.Products.Configurations;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using agrokorm.Models.Enum;

namespace agrokorm.Models.Products
{
    public class Membrane : IBaseProduct
    {
 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Color { get; set; }
        
        [Required]
        public int Width { get; set; }

        [Required]
        public int Lenght { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int Price { get; set; }  
        
        [Required]
        public string Description { get; set; }

        public bool IsVisible { get; set; }

        public ICollection<MembraneConfiguration> membraneConfigurations { get; set; } 

        public CategoryEnum Category { get; set; }
    }
}
