using agrokorm.Models.Enum;
using agrokorm.Models.Products.Configurations;
using System.Collections.Generic;

namespace agrokorm.Models.Products
{
    public class Seed : IBaseProduct
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public CategoryEnum Category { get ; set ; }
        public List<SeedConfiguration> configurations { get; set; }
        public bool IsVisible { get; set; }
    }
}
