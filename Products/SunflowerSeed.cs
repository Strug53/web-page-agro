using agrokorm.Models.Products.Configurations;

namespace agrokorm.Models.Products
{
    public class SunflowerSeed 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string PlaceOfProduction { get; set; }
        public string Technology { get; set; }
        public string Price { get; set; }
        public bool IsVisible { get; set; }
        public string Category { get; set; }
    }
}
