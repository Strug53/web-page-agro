

namespace agrokorm.Models.Products.Configurations
{
    public class SeedConfiguration : IBaseConfiguration
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlaceOfProduction { get; set; }
        public int Price { get ; set; }
        public int SeedId { get; set; }
    }
}
